using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult EmailForm()
        {
            List<Email> mails = new List<Email> {
                new Email {
                    To = "KhanhN@fpt.edu.vn",
                    Subject = "Title"
                },
                new Email {
                    To = "khanhdsp@gmail.com",
                    Subject = "Tieu de"
                }
            };
            ViewBag.Emails = new SelectList(mails, "To", "Subject");
            return View();
        }
        [HttpPost]
        public ActionResult EmailForm(Email email)
        {
            return View("EmailInfo", email); ;
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}