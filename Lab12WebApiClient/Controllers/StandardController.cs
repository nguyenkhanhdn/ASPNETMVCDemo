using Lab12WebApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Lab12WebApiClient.Controllers
{
    public class StandardController : Controller
    {
        SchoolEntities db = new SchoolEntities();

        // GET: Standard
        public ActionResult Index()
        {
            var standards = db.Standards.ToList();
            return View(standards);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Standard standard)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/ws/api/Standards");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Standard>("Standards", standard);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(standard);
        }
    }
}