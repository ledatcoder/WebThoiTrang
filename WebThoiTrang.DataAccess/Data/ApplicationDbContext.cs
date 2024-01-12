using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebThoiTrang.Models;

namespace WebThoiTrang.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
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
