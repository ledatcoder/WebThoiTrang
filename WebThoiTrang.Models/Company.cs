using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace WebThoiTrang.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên Công Ty")]
        public string Name { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string StreetAddress { get; set; }
        [Display(Name = "Tên Thành Phố")]
        public string City { get; set; }
        [Display(Name = "Tên Quốc Gia")]
        public string State { get; set; }
        [Display(Name = "Mã Bưu Điện")]
        public string PostalCode { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string PhoneNumber { get; set; }
    }
}
