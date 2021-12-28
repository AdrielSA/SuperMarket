using CoreBusiness.Entities;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddProductUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Execute(Product product)
        {
            _unitOfWork.ProductRepository.AddProduct(product);
        }
    }
}
