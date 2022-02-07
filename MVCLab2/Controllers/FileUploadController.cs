using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab2.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }
        // GET: FileUpload
        public ActionResult Upload()
        {

            var file = Request.Files["document"];
            if (file != null)
            {
                var path = Server.MapPath("/Files/" + file.FileName);
                file.SaveAs(path);
                ViewBag.FileName = file.FileName;
                ViewBag.Status = "Saved";
            }
            return View();
        }
        public ActionResult Read()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Read(string sname, string semail)
        {
            var path = Server.MapPath("/Files/" + "studentinfo.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            ViewBag.SName = lines[0];
            ViewBag.Email = lines[1];
            return View();
        }
        public ActionResult Write()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Write(string sname, string semail)
        {
            var path = Server.MapPath("/Files/" + "studentinfo.txt");
            string [] lines = { sname, semail };
            System.IO.File.WriteAllLines(path,lines);
            return View();
        }
    }
}