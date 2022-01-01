using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}
