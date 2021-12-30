using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoriesUseCase
    {
        Task<IEnumerable<Category>> Execute();
    }
}
