using Microsoft.EntityFrameworkCore;
using WebThoiTrang.Models;

namespace WebThoiTrang.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Áo Sơ Mi", DisplayOrder = 1},
                new Category { Id = 2, Name = "Áo Polo Thể Thao", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Áo Len Nam", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Áo Len Nữ", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Áo Polo Nam", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Váy Nữ", DisplayOrder = 6 }

                );
        }
    }
}
