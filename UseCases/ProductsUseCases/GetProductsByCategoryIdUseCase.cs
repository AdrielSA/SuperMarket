using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Products;

namespace UseCases.ProductsUseCases
{
    public class GetProductsByCategoryIdUseCase : IGetProductsByCategoryIdUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductsByCategoryIdUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> Execute(int categoryId)
        {
            return await _unitOfWork.ProductRepository.GetProductsByCategoryId(categoryId);
        }
    }
}
