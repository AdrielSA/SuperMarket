using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStoreInterfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category> GetCategoryById(int categoryId);

        Task AddCategory(Category category);

        Task UpdateCategory(Category category);

        Task DeleteCategory(int categoryId);
    }
}
