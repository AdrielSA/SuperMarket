using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class CategoriesComponent
    {
        private IEnumerable<Category> categories;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
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
            categories = ViewCategoryUseCase.Execute();
        }
    }
}
