using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext():base("name=EFDemo")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // other code 
            //Database.SetInitializer<CustomerContext>(null);
            // more code
        }
        //public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}