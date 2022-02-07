using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var user = new List<User>();
            var user1 = new User();
            user1.Name = "Mark Smith";
            user1.Address = "Park Street";
            user1.Email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.Name = "John Parker";
            user2.Address = "New Park";
            user2.Email = "John@mvcexample.com";
            var user3 = new User();
            user3.Name = "Steave Edward ";
            user3.Address = "Melbourne Street";
            user3.Email = "steave@mvcexample.com";
            user.Add(user1);
            user.Add(user2);
            user.Add(user3);
            ViewBag.user = user;
            return View();
        }
        public ActionResult Index2()
        {
            var user = new List<User>();
            var user1 = new User();
            user1.Name = "Mark Smith";
            user1.Address = "Park Street";
            user1.Email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.Name = "John Parker";
            user2.Address = "New Park";
            user2.Email = "John@mvcexample.com";
            var user3 = new User();
            user3.Name = "Steave Edward ";
            user3.Address = "Melbourne Street";
            user3.Email = "steave@mvcexample.com";
            user.Add(user1);
            user.Add(user2);
            user.Add(user3);
            return View(user);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int UserId, string Name, string Address, string Email)
        {
            //var user = new { UserId = UserId, Name = Name, Address = Address, Email = Email };
            //ViewBag.User = user;
            var user = new User();
            user.UserId = UserId;
            user.Name = Name;
            user.Address = Address;
            user.Email = Email;
            return View("CreateInfo", user);
        }

        //[httppost]
        //public actionresult create(int userid, string name, string address, string email)
        //{
        //    //var user = new { userid = userid, name = name, address = address, email = email };
        //    //viewbag.user = user;
        //    var user = new user();
        //    user.userid = userid;
        //    user.name = name;
        //    user.address = address;
        //    user.email = email;
        //    return view("createinfo",user);
        //}
    }
}