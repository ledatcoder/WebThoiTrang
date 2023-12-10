using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace WebThoiTrang.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200,ErrorMessage = "Tên Không Dài Quá 200 Ký Tự")]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Danh Sách Giá")]
        [Range(1, 100000000)]
        public double ListPrice { get; set; }
        [Required]
        [Display(Name = "Giá 1 Cái")]
        [Range(1, 100000000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Giá 2 -> 5 Cái")]
        public double Price5 { get; set; }
        [Required]
        [Display(Name = "Giá Từ 6 Cái")]
        public double Price6 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [ValidateNever]
        public List<ProductImage> ProductImages { get; set; }
    }
}
