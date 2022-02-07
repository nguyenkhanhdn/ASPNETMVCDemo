using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NotMapProperty.Models
{
    public class Customer
    {
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ScaffoldColumn(true)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }

    
}