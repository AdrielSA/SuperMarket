using CoreBusiness.Entities;
using System.Threading.Tasks;
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

        public async Task Execute(Category category)
        {
            await _unitOfWork.CategoryRepository.UpdateCategory(category);
        }
    }
}
