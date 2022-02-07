using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WADReview.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="Firstname không được rỗng.")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname không được rỗng.")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được rỗng.")]
        [StringLength(100)]
        public string Address { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required(ErrorMessage = "Email không được rỗng.")]
        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}