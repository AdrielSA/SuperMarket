using CoreBusiness.Entities;
using System.Collections.Generic;

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
