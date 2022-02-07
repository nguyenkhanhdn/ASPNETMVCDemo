using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public string ExamineTextBox(string textBox1)
        {
            if (textBox1 != "Initial Data")
            {
                return "This text is MVC different from before! " + textBox1;
            }
            return String.Empty;
        }
    }
}