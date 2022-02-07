using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Standard
    {
        public Standard()
        {
            Students = new List<Student>();
        }
        public int StandardId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
   
}