using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;

namespace DataStore.InMemory.ImMemoryRepositories
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private readonly List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1 , Name = "Refresco", Quantity = 200, Price = 84.99 },
                new Product { ProductId = 2, CategoryId = 1 , Name = "Jugo", Quantity = 150, Price = 14.99 },
                new Product { ProductId = 3, CategoryId = 2 , Name = "Pan integral", Quantity = 50, Price = 79.99 },
                new Product { ProductId = 4, CategoryId = 2 , Name = "Pan de mantequilla", Quantity = 75, Price = 79.99 },
                new Product { ProductId = 5, CategoryId = 3 , Name = "Carne de res", Quantity = 15, Price = 314.99 },
                new Product { ProductId = 6, CategoryId = 3 , Name = "Carne de pollo", Quantity = 35, Price = 209.99 }
            };
        }

        public void AddProduct(Product product)
        {
            var compare = products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));
            if (compare) return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int productId)
        {
            return products?.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products?.Where(x => x.CategoryId == categoryId);
        }

        public void UpdateProduct(Product product)
        {
            var categoryToUpdate = GetProductById(product.ProductId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryId = product.CategoryId;
                categoryToUpdate.Name = product.Name;
                categoryToUpdate.Quantity = product.Quantity;
                categoryToUpdate.Price = product.Price;
            }
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }
    }
}
