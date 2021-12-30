using CoreBusiness.Entities;
using DataStore.SQL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task AddCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int categoryId)
        {
            var cat = await GetCategoryById(categoryId);
            if (cat == null) return;
            _context.Categories.Remove(cat);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task UpdateCategory(Category category)
        {
            var cat = await GetCategoryById(category.CategoryId);
            cat.Name = category.Name;
            cat.Description = category.Description;
            _context.Categories.Update(cat);
            await _context.SaveChangesAsync();
        }
    }
}
