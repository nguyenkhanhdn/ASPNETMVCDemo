using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class CatProViewModel
    {
        public List<Category> Categories{ get; set; }
        public List<Product> Products { get; set; }
    }
}