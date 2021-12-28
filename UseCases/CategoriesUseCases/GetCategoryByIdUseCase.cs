using CoreBusiness.Entities;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoryByIdUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Category Execute(int categoryId)
        {
           return _unitOfWork.CategoryRepository.GetCategoryById(categoryId);
        }
    }
}
