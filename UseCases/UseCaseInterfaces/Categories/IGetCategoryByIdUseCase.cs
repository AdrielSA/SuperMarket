using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Task<Category> Execute(int categoryId);
    }
}
