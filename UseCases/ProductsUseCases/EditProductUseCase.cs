using CoreBusiness.Entities;
using System.Threading.Tasks;
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
        public async Task Execute(Product product)
        {
            await _unitOfWork.ProductRepository.UpdateProduct(product);
        }
    }
}
