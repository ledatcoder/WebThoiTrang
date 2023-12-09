using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebThoiTrang.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "Tên Không Dài Hơn 50 Ký Tự")]
        [Display(Name= "Tên Danh Mục")]
        public string Name { get; set; }
        [Display(Name = "Thứ Tự Hiển Thị")]
        public int DisplayOrder { get; set; }
    }
}
