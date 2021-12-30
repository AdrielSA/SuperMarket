using CoreBusiness.Entities;
using DataStore.SQL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;

namespace DataStore.SQL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext _context;

        public ProductRepository(MarketContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var prod = await GetProductById(productId);
            if (prod == null) return;
            _context.Products.Remove(prod);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId)
        {
            var products = _context.Products.Where(x => x.CategoryId == categoryId).AsQueryable();
            return await products.ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            var prod = await GetProductById(product.ProductId);
            prod.CategoryId = product.CategoryId;
            prod.Name = product.Name;
            prod.Quantity = product.Quantity;
            prod.Price = product.Price;
            _context.Products.Update(prod);
            await _context.SaveChangesAsync();
        }
    }
}
