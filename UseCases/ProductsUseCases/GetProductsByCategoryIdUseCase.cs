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

        public IEnumerable<Product> Execute(int categoryId)
        {
            return _unitOfWork.ProductRepository.GetProductsByCategoryId(categoryId);
        }
    }
}
