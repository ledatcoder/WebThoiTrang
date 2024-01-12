using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace WebThoiTrang.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nhập Mã Giảm Giá")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Loãi Phiếu Giảm Giá")]
        public string CouponType { get; set; }

        public enum ECouponType { Percent = 1, VND = 0 }

        [Required]
        [Display(Name = "Số Tiền Muốn Giảm Lớn Nhất")]
        public double Discount { get; set; }

        [Required]
        [Display(Name = "Số Tiền Giảm Tối Thiểu")]
        public double MinimumAmount { get; set; }
        [Display(Name = "Hình Ảnh Voucher")]
        public byte[] Picture { get; set; }

        [Display(Name = "Phát Hành Mã GIảm Giá")]
        public bool IsActive { get; set; }
    }
}
