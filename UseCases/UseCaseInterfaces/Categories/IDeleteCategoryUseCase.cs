using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IDeleteCategoryUseCase
    {
        void Delete(int categoryId);
    }
}
