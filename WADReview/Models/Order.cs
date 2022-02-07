using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WADReview.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [DataType(DataType.Date)]
        [Required()]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.Date)]
        [Required()]
        [Display(Name ="Ngày giao hàng")]
        public DateTime RequiredDate { get; set; }
        [Required()]
        [StringLength(100)]
        [Display(Name = "Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }
        [Required()]
        [StringLength(100)]
        public string ContactName { get; set; }
        [Required()]
        [StringLength(20)]
        public string Phone { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> Products { get; set; }
    }
}