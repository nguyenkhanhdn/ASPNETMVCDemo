using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Register(string Id, string Name, string Mark)
        //{
        //    //var id = Request.QueryString["Id"].ToString();
        //    //var name = Request.QueryString["Name"].ToString();
        //    //var mark = Request.QueryString["Mark"].ToString();
        //    ViewBag.Id = Id;
        //    ViewBag.Name = Name;
        //    ViewBag.Mark = Mark;
        //    return View();
        //}
        //public ActionResult Register(FormCollection fields)
        //{

        //    ViewBag.Id = fields["Id"];
        //    ViewBag.Name = fields["Name"];
        //    ViewBag.Mark = fields["Mark"];
        //    return View();
        //}
        public ActionResult Register(StudentInfo si)
        {

            //ViewBag.Id =si.Id;
            ViewData["Id"] = si.Id;
            ViewBag.Name = si.Name;
            ViewBag.Mark = si.Mark;
            return View();
        }
    }
}