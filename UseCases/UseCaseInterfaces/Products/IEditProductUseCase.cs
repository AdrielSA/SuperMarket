using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IEditProductUseCase
    {
        Task Execute(Product product);
    }
}
