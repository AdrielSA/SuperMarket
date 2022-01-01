using CoreBusiness.Entities;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductByIdUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Product Execute(int productId)
        {
            return _unitOfWork.ProductRepository.GetProductById(productId);
        }
    }
}
