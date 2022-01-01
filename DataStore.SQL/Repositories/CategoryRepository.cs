using CoreBusiness.Entities;
using DataStore.SQL.Context;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStoreInterfaces;

namespace DataStore.SQL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketContext _context;

        public CategoryRepository(MarketContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var cat = GetCategoryById(categoryId);
            if (cat == null) return;
            _context.Categories.Remove(cat);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var cat = GetCategoryById(category.CategoryId);
            cat.Name = category.Name;
            cat.Description = category.Description;
            _context.Categories.Update(cat);
            _context.SaveChanges();
        }
    }
}
