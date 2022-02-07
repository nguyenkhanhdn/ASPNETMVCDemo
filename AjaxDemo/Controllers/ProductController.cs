using AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductHtml()
        {
            ProductModel model = new ProductModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult ProductHtml(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("Product Name :" + model.Name + "</br/>");
                sb.Append("Description :" + model.Description + "</br/>");
                sb.Append("Manufacturer :" + model.Manufacturer + "</br/>");
                sb.Append("Price :" + model.BasePrice + "</br/>");
                sb.Append("Category :" + model.Category[model.CategoryId - 1].Text);
                return Content(sb.ToString());
            }
            else
            {
                return View(model);
            }
        }
        public ActionResult ProductAjax()
        {
            ProductModel model = new ProductModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult ProductAjax(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Product Name :" + model.Name + "</br/>");
                sb.Append("Description :" + model.Description + "</br/>");
                sb.Append("Manufacturer :" + model.Manufacturer + "</br/>");
                sb.Append("Price :" + model.BasePrice + "</br/>");
                sb.Append("Category :" + model.Category[model.CategoryId - 1].Text);
                return Content(sb.ToString());
            }
            else
            {
                return View(model);
            }
        }
    }
}