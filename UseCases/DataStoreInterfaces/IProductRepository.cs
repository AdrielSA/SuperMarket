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
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        IEnumerable<Product> GetProductsByCategoryId(int categoryId);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
