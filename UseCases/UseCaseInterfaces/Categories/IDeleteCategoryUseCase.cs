using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IDeleteCategoryUseCase
    {
        Task Delete(int categoryId);
    }
}
