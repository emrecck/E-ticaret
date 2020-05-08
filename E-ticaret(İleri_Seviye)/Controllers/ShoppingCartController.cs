using E_ticaret_İleri_Seviye_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_ticaret_İleri_Seviye_.Controllers
{
    public class ShoppingCartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int id)
        {
            var course = db.Courses.Where(i => i.Id == id).FirstOrDefault();
            if( course != null )
            {
                GetCart().AddCartLine(course);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart() 
        {
            var cart = (Cart)Session["Cart"];
            if( cart == null )
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }
        public ActionResult RemoveFromCart(int id) 
        {
            GetCart().DeleteFromCartLine(db.Courses.FirstOrDefault(i => i.Id == id));
            return RedirectToAction("Index");
        }
    }
}