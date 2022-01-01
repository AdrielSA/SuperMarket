using CoreBusiness.Entities;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class AddCategoryComponent
    {
        private Category category;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            category = new Category();
        }

        private void AddCategory()
        {
            AddCategoryUsaCase.Execute(category);
            NavigationManager.NavigateTo("/categorias");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/categorias");
        }
    }
}
