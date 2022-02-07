using SecurityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemo.Controllers
{
    //[Authorize(Roles = "Manager")]
    public class UsersController : Controller
    {
        ApplicationDbContext context;
        // GET: Users
        public ActionResult Index()
        {
            context = new ApplicationDbContext();
            var users = context.Users.ToList();
            return View(users);
        }
    }
}