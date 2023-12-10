using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebThoiTrang.DataAccess.Data;
using WebThoiTrang.DataAccess.Repository.IRepository;
using WebThoiTrang.Models;

namespace WebThoiTrang.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
