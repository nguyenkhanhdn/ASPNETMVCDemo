using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewLab5Demo.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base(){
        }
        public DbSet<Movie> Movies{ get; set; }
    }
}