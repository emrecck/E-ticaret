using E_ticaret_İleri_Seviye_.Identity;
using E_ticaret_İleri_Seviye_.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_ticaret_İleri_Seviye_.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userstore = new UserStore<ApplicationUser>(new IdentityDataContext());
            var rolestore = new RoleStore<ApplicationRole>(new IdentityDataContext());

            UserManager = new UserManager<ApplicationUser>(userstore);
            RoleManager = new RoleManager<ApplicationRole>(rolestore);
        }
        [Authorize]
        public ActionResult MyProfile()
        {
            if( db.Orders.Count() != 0 )
            {

            }
            List<Order> orders = db.Orders.Where(j => j.UserName == User.Identity.Name).ToList();
            return View(orders);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register register)
        {
            if( ModelState.IsValid )
            {

                ApplicationUser applicationUser = new ApplicationUser();
                applicationUser.Name = register.Name;
                applicationUser.Surname = register.Surname;
                applicationUser.Email = register.Email;
                applicationUser.UserName = register.Username;

                var result = UserManager.Create(applicationUser , register.Password);

                if( result.Succeeded )
                {
                    if( RoleManager.RoleExists("User") )
                    {
                        UserManager.AddToRole(applicationUser.Id , "User");
                    }
                    return RedirectToAction("Login" , "Account");
                }
            }
            else
            {
                ModelState.AddModelError("usercreateerror" , "Kullanıcı oluşturma hatası.");
            }


            return View(register);
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login , string returnUrl)
        {
            if( ModelState.IsValid )
            {
                var user = UserManager.Find(login.Username , login.Pasword);

                if( user != null )
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityClaims = UserManager.CreateIdentity(user , "ApplicationCookie");
                    var authProp = new AuthenticationProperties();
                    authProp.IsPersistent = login.RememberMe;

                    authManager.SignIn(authProp , identityClaims);

                    if( !String.IsNullOrEmpty(returnUrl) )
                    {
                        return Redirect(returnUrl);
                    }
                    else
                        return RedirectToAction("Index" , "Home");
                }

            }
            else
            {
                ModelState.AddModelError("LoginUserError" , "Böyle bir kullanıcı yok");
            }
            return View(login);
        }
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index" , "Home");
        }
    }
}