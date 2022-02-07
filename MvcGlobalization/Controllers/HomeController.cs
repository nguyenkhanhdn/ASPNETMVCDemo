using MvcGlobalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcGlobalization.Controllers
{
    public class HomeController : Controller
    {
        private static List<Demo> list = new List<Demo>();
        public ActionResult Index()
        {
         
            return View(list);
        }
        public ActionResult Lang(string id)
        {
            string culture = null;
            if(id=="EN")
            {
                culture = "en-US";
            }else
            {
                culture = "vi-VN";
            }
            Session["culture"] = culture;
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Demo model)
        {
            if (ModelState.IsValid)
            {
                list.Add(model);
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
    }
}