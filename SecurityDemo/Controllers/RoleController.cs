using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecurityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemo.Controllers
{
    [Authorize(Roles ="admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext context;
        public RoleController()
        {
            context = new ApplicationDbContext();
        }
        [Authorize()]
        public ActionResult X()
        {
            return View();
        }
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
//            return View();
            return View(Roles);
//            return View("ViewName");
//            return View("ViewName",Roles);
        }
        public string GetRoles(){
            return "Admin, Managers";
        }
        [HttpGet]
        public ActionResult AddUserToRole()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = from u in context.Users
                select u;
                // ViewBag.Users = new SelectList(users, "Id", "UserName");
                ViewBag.UserName = users.Select(x => new SelectListItem {Text = x.UserName, Value = x.Id }).ToList();
                var roles = from r in context.Roles
                            select r;
                ViewBag.Name = roles.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddUserToRole(string UserName, string Name)
        {
            //var context = new AccountController();
            var context = new ApplicationDbContext();

            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(roleStore);

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.AddToRole(UserName,Name);

            //userManager.AddToRole(UserName, Name);

            ViewBag.Name = UserName;
            ViewBag.Role = Name;
            return View("AddConfirm");
        }
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}