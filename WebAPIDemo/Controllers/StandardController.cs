using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class StandardController : Controller
    {
        SchoolDbEntities db = new SchoolDbEntities();

        // GET: Standard
        public ActionResult Index()
        {
            IEnumerable<Standard> standards = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");
                //HTTP GET
                var responseTask = client.GetAsync("Standards");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Standard>>();
                    readTask.Wait();
                    standards = readTask.Result;
                }
                else //web api sent error response 
                {
                    standards = Enumerable.Empty<Standard>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(standards);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Standard standard = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");
                //HTTP GET
                var responseTask = client.GetAsync("Standards?id=" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Standard>();
                    readTask.Wait();
                    standard = readTask.Result;
                }
            }
            return View(standard);
        }

        [HttpPost]
        public ActionResult Edit(Standard standard)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<Standard>("Standards", standard);
                putTask.Wait();
                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(standard);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            Standard standard = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");
                //HTTP GET
                var responseTask = client.GetAsync("Standards?id=" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Standard>();
                    readTask.Wait();
                    standard = readTask.Result;
                }
            }
            return View(standard);
        }

        [HttpPost]
        public ActionResult create(Standard standard)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Standard>("Standards",standard);
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
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53630/Api/Standards");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Standards/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}