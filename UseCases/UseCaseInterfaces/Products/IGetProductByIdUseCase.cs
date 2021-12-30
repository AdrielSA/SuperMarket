using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductByIdUseCase
    {
        Task<Product> Execute(int productId);
    }
}
