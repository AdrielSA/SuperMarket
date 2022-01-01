using CoreBusiness.Entities;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddCategoryUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Execute(Category category)
        {
            _unitOfWork.CategoryRepository.AddCategory(category);
        }
    }
}
