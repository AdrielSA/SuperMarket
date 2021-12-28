using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Delete(int productId)
        {
            _unitOfWork.ProductRepository.DeleteProduct(productId);
        }
    }
}
