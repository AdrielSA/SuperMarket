using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class CategoriesComponent
    {
        private List<Category> categories;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Load();
        }

        private void AddCategory()
        {
            NavigationManager.NavigateTo("/agregarcategoria");
        }

        private void EditCategory(Category category)
        {
            NavigationManager.NavigateTo($"/editarcategoria/{category.CategoryId}");
        }

        private void DeleteCategory(int categoryId)
        {
            DeleteCategoryUseCase.Delete(categoryId);
            Load();
        }

        private void Load()
        {
            categories = ViewCategoryUseCase.Execute().ToList();
        }
    }
}
