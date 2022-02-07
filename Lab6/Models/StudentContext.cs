using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab6.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentDB")
        { }
        public DbSet<Student> Students { get; set; }
    }
}