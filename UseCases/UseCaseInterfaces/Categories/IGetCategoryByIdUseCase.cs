using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}
