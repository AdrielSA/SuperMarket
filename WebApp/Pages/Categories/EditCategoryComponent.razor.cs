using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class EditCategoryComponent
    {
        [Parameter]
        public string CategoryId { get; set; }
        private Category category;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            category = new Category();
        }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            if (int.TryParse(CategoryId, out int Id))
            {
                var cat = category = GetCategoryByIdUseCase.Execute(Id);
                category = new Category { CategoryId = cat.CategoryId, Name = cat.Name, Description = cat.Description };
            }
        }

        private void EditCategory()
        {
            EditCategoryUseCase.Execute(category);
            NavigationManager.NavigateTo("/categorias");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/categorias");
        }
    }
}
