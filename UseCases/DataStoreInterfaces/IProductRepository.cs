using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStoreInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProductById(int productId);

        Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId);

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(int productId);
    }
}
