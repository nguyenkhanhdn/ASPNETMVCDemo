using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WADReview.Models
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext():base("ShopDb")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<NorthwindContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}