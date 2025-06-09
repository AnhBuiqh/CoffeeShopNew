
using TH01.Data;
using TH01.Models.Interface;

namespace TH01.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private TH01DbContext dbContext;
        public ProductRepository(TH01DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
} 

