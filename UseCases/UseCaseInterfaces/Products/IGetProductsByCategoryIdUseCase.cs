using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductsByCategoryIdUseCase
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}
