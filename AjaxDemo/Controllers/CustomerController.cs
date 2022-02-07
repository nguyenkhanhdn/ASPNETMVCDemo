using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string customerId)
        {
            Models.NorthwindDBDataContext db = new Models.NorthwindDBDataContext();
            var customer = (from c in db.Customers
                           where c.CustomerID.Contains(customerId)
                           select c).FirstOrDefault();
            return PartialView("_Customer", customer);
        }
    }
}