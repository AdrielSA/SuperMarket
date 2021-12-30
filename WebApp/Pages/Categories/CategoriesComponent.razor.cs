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
            await Load();
        }

        private void AddCategory()
        {
            NavigationManager.NavigateTo("/agregarcategoria");
        }

        private void EditCategory(Category category)
        {
            NavigationManager.NavigateTo($"/editarcategoria/{category.CategoryId}");
        }

        private async Task DeleteCategory(int categoryId)
        {
            await DeleteCategoryUseCase.Delete(categoryId);
            await Load();
        }

        private async Task Load()
        {
            categories = await ViewCategoryUseCase.Execute();
        }
    }
}
