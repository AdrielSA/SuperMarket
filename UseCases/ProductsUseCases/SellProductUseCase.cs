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

        public void Execute(string cashierName, int  productId, int qtyToSell)
        {
            var product = _unitOfWork.ProductRepository.GetProductById(productId);
            if (product == null) return;
            _unitOfWork.TransactionRepository.Save(cashierName, productId, product.Name,
                product.Price.Value, product.Quantity.Value, qtyToSell);
            product.Quantity -= qtyToSell;
            _unitOfWork.ProductRepository.UpdateProduct(product);
        }
    }
}
