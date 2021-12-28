using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStoreInterfaces;

namespace DataStore.InMemory.ImMemoryRepositories
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category {CategoryId = 1, Name = "Bebida", Description = "Bebida"},
                new Category{ CategoryId = 2, Name = "Panaderia", Description = "Panaderia"},
                new Category {CategoryId = 3, Name = "Carne", Description = "Carne"}
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void AddCategory(Category category)
        {
            var compare = categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase));
            if (compare) return;
            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
