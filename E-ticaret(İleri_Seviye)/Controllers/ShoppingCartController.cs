using E_ticaret_İleri_Seviye_.Identity;
using E_ticaret_İleri_Seviye_.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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
        [Authorize]
        public ActionResult Checkout()
        {
            var cart = GetCart();
            SaveOrder(cart);

            return View();
        }

        private void SaveOrder(Cart cart)
        {
            var order = new Order();

            order.Date = DateTime.Now;
            order.OrderLines = new List<OrderLine>();
            order.UserName = User.Identity.GetUserName();
            foreach( var item in cart.CartLines )
            {
                var orderLine = new OrderLine();
                orderLine.CourseName = item.Course.CourseName;
                orderLine.Price = item.Course.Price;
                orderLine.CourseId = item.Course.Id;

                order.OrderLines.Add(orderLine);
            }

            db.Orders.Add(order);
            db.SaveChanges();
        }

    }
}