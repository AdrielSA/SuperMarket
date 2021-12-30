using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SellProductUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(string cashierName, int  productId, int qtyToSell)
        {
            var product = await _unitOfWork.ProductRepository.GetProductById(productId);
            if (product == null) return;
            await _unitOfWork.TransactionRepository.Save(cashierName, productId, product.Name,
                product.Price.Value, product.Quantity.Value, qtyToSell);
            product.Quantity -= qtyToSell;
            await _unitOfWork.ProductRepository.UpdateProduct(product);
        }
    }
}
