using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class GetProductsUseCase : IGetProductsUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductsUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> Execute()
        {
            return await _unitOfWork.ProductRepository.GetProducts();
        }
    }
}
