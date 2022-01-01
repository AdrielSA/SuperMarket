using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Linq;

namespace UseCases.DataStoreInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        IQueryable<Product> GetProductsByCategoryId(int categoryId);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
