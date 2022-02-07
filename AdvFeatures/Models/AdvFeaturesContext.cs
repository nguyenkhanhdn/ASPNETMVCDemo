using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvFeatures.Models
{
    public class AdvFeaturesContext:DbContext
    {
        public AdvFeaturesContext():base("name=Db")
        {
            //Database.SetInitializer<AdvFeaturesContext>(new DropCreateDatabaseAlways<AdvFeaturesContext>());
        }
        public DbSet<Student> Students { get; set; }
    }        
}