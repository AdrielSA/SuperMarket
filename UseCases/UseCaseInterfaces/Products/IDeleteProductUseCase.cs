using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IDeleteProductUseCase
    {
        Task Delete(int productId);
    }
}
