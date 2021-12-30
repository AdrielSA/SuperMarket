using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IAddProductUseCase
    {
        Task Execute(Product product);
    }
}
