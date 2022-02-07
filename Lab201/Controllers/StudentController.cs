using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab201.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            var id = Request.QueryString["Id"].ToString();
            var name = Request.QueryString["Name"].ToString();
            var mark = Request.QueryString["Mark"].ToString();
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Mark = mark;

            return View();
        }
    }
}