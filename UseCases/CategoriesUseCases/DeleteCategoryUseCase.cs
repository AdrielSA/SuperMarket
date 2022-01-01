using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Delete(int categoryId)
        {
            _unitOfWork.CategoryRepository.DeleteCategory(categoryId);
        }
    }
}
