using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NotMapProperty.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=EFTest")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
        }
        public DbSet<Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<NotMapProperty.Models.CustomerViewModel> CustomerViewModels { get; set; }
    }
}