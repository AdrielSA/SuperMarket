using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IEditProductUseCase
    {
        void Execute(Product product);
    }
}
