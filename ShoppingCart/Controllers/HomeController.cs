using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            
            Models.NorthwindEntities db = new Models.NorthwindEntities();
            CatProViewModel cp = new CatProViewModel();
            
            if(id.HasValue){
                var products = from p in db.Products
                               where p.Category.CategoryID == id
                               select p;
                cp.Products = products.ToList<Product>();
                cp.Categories = db.Categories.ToList<Category>();
                
            }else{
                cp.Products = db.Products.ToList<Product>();
                cp.Categories = db.Categories.ToList<Category>();
                
            }
            return View(cp);
        }
        public ActionResult AddToCart(int id, int quantity =1)
        {
            ShoppingCart cart = (ShoppingCart)Session["cart"];
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            cart.AddItem(id.ToString(), quantity, 300);
            //Save cart
            Session["cart"] = cart;
            return RedirectToAction("YourCart");
        }
        public ActionResult YourCart()
        {
            //Models.NorthwindEntities db = new Models.NorthwindEntities();
            //return View(db.Categories.Include("Products").ToList());
            return View();
        }
        public ActionResult Category(int? id)
        {
            if(!id.HasValue){
                return RedirectToAction("Index");
            }
            Models.NorthwindEntities db = new Models.NorthwindEntities();
            var categories = from c in db.Categories.Include("Products")
            where c.CategoryID==id
            select c;

            return View(categories.ToList());
        }
        public ActionResult RemoveItem(int id)
        {
            ShoppingCart cart = (ShoppingCart)Session["cart"];
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            cart.RemoveItem(id.ToString());
            return RedirectToAction("YourCart");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}