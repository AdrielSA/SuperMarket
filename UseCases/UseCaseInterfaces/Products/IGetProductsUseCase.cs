using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductsUseCase
    {
        Task<IEnumerable<Product>> Execute();
    }
}
