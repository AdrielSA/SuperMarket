using CoreBusiness.Entities;
using DataStore.SQL.Context;
using System.Collections.Generic;
using System.Linq;
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

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var prod = GetProductById(productId);
            if (prod == null) return;
            _context.Products.Remove(prod);
            _context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public void UpdateProduct(Product product)
        {
            var prod = GetProductById(product.ProductId);
            prod.CategoryId = product.CategoryId;
            prod.Name = product.Name;
            prod.Quantity = product.Quantity;
            prod.Price = product.Price;
            _context.Products.Update(prod);
            _context.SaveChanges();
        }
    }
}
