using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class GetCategoriesUseCase : IGetCategoriesUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoriesUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> Execute()
        {
            return _unitOfWork.CategoryRepository.GetCategories();
        }
    }
}
