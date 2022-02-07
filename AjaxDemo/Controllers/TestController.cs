using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestBeginForm()
        {
            return View();
        }
        public PartialViewResult InsertText(string text)
        {
            ViewBag.TextToDisplay = text;
            return PartialView();
        }
        public ActionResult GetText(string q)
        {
            ViewBag.TheText = q;
            return PartialView();
        }
        public ActionResult NewInsert(string textToInsert)
        {
            ViewBag.TheText = textToInsert;
            return PartialView();
        }
        [HttpPost]
        public ActionResult PostInsert(string p)
        {
            ViewBag.TheText = p;
            return PartialView();
        }
    }
}