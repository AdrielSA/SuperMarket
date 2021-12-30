using System.Threading.Tasks;
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

        public async Task Delete(int productId)
        {
            await _unitOfWork.ProductRepository.DeleteProduct(productId);
        }
    }
}
