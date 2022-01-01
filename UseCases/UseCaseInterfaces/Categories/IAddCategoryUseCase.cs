using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}
