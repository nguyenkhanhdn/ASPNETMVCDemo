using AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        Models.NorthwindDBDataContext db = new Models.NorthwindDBDataContext();

        
        public PartialViewResult Germany()
        {
            var result = from r in db.Customers
                         where r.Country == "Germany"
                         select r;
            return PartialView("_Country", result);
        }
        public PartialViewResult Mexico()
        {
            var result = from r in db.Customers
                         where r.Country == "Mexico"
                         select r;
            return PartialView("_Country", result);
        }
        public ActionResult Index()
        {
            return View();
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