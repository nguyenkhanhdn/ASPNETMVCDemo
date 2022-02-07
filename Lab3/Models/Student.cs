using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Student
    {
        [DisplayName("Mã sinh viên")]
        public int Id { get; set; }
        [DisplayName("Mật khẩu"),DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Họ và tên")]
        public string Fullname{ get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime Birthday { get; set; }
        [DisplayName("Ghi chú"),DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}