using ShoppingCart.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            //List<MenuViewModel> menuViewModel = new List<MenuViewModel>();

            //MenuViewModel menu = new MenuViewModel() { MenuID = 1, Action = "Index", Controller = "Dashboard", IsAction = true, Class = "class", SubMenu = null, Title = "Dashboard" };
            //menuViewModel.Add(menu);

            //menu = new MenuViewModel() { MenuID = 2, IsAction = false, Class = "class", Link = "javascript:void(0);", Title = "Application Setup" };

            //menu.SubMenu = new List<MenuViewModel>();
            //MenuViewModel subMenu = new MenuViewModel() { Action = "Register", Controller = "Account", IsAction = true, Class = "", SubMenu = null, Title = "User Manager" };
            //menu.SubMenu.Add(subMenu);

            //subMenu = new MenuViewModel() { Action = "Index", Controller = "Manage", IsAction = true, Class = "", SubMenu = null, Title = "Manage" };
            //menu.SubMenu.Add(subMenu);

            //subMenu = new MenuViewModel() { Action = "ChangePassword", Controller = "Manage", IsAction = true, Class = "", SubMenu = null, Title = "Change Password" };
            //menu.SubMenu.Add(subMenu);

            //subMenu = new MenuViewModel() { IsAction = false, Link = "javascript:document.getElementById('logoutForm').submit()", Class = "", SubMenu = null, Title = "Logoff" };
            //menu.SubMenu.Add(subMenu);

            //menuViewModel.Add(menu);

            Models.NorthwindEntities db = new Models.NorthwindEntities();
            var categories = db.Categories.ToList() ;
            CatProViewModel cp = new CatProViewModel();
            cp.Categories = categories;
            cp.Products = db.Products.ToList();
            return PartialView("_Navigation", cp);
        }
    }
}