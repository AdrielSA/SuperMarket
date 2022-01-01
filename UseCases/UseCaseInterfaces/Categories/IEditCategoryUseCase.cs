using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IEditCategoryUseCase
    {
        void Execute(Category category);
    }
}
