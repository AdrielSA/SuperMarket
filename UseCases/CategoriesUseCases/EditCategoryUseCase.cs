using CoreBusiness.Entities;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly IUnitOfWork _unitOfWork; 

        public EditCategoryUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Execute(Category category)
        {
            _unitOfWork.CategoryRepository.UpdateCategory(category);
        }
    }
}
