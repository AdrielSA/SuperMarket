using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}
