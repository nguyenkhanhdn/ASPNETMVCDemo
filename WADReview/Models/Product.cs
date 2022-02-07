using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WADReview.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Tên hàng bắt buộc phải nhập.")]
        [StringLength(100)]
        public string ProductName { get; set; }
        [Required()]
        [StringLength(100)]
        public string ProductImg { get; set; }        
        public float Price { get; set; }
        public int QtyInStock { get; set; }

        public ICollection<OrderDetail> Orders { get; set; }
    }
}