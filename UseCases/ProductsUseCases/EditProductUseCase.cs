using CoreBusiness.Entities;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IUnitOfWork _unitOfWork; 
        
        public EditProductUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Execute(Product product)
        {
            _unitOfWork.ProductRepository.UpdateProduct(product);
        }
    }
}
