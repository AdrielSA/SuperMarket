using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface ISellProductUseCase
    {
        Task Execute(string cashierName, int productId, int qtyToSell);
    }
}
