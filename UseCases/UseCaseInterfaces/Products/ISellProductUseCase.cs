using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface ISellProductUseCase
    {
        void Execute(string cashierName, int productId, int qtyToSell);
    }
}
