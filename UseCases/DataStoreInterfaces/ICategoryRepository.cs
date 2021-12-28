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
        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int categoryId);

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int categoryId);
    }
}
