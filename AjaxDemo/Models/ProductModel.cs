using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            Category = new List<SelectListItem>();
            Category.Add(new SelectListItem
            {
                Text = "Books",
                Value = "1"
            });
            Category.Add(new SelectListItem
            {
                Text = "Mobiles & Tablets",
                Value = "2"
            });
            Category.Add(new SelectListItem
            {
                Text = "Laptops & Accessories",
                Value = "3"
            });
        }

        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal BasePrice { get; set; }
        public IList<SelectListItem> Category { get; set; }
        public int CategoryId { get; set; }
    }
}