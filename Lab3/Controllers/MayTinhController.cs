using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class MayTinhController : Controller
    {
        // GET: MayTinh
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(double a, double b, char o='+')
        {
            switch (o)
            {
                case '+':
                    ViewBag.Kq = a + b;
                    break;
                case '-':
                    ViewBag.Kq = a - b;
                    break;
                case '*':
                    ViewBag.Kq = a * b;
                    break;
                case '/':
                    ViewBag.Kq = a / b;
                    break;
            }
            return View();
        }
    }
}