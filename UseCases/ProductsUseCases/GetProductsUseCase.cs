using CoreBusiness.Entities;
using System.Collections.Generic;
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

        public IEnumerable<Product> Execute()
        {
            return _unitOfWork.ProductRepository.GetProducts();
        }
    }
}
