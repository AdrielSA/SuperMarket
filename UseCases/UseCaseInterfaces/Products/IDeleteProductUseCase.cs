using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IDeleteProductUseCase
    {
        void Delete(int productId);
    }
}
