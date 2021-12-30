using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IAddCategoryUseCase
    {
        Task Execute(Category category);
    }
}
