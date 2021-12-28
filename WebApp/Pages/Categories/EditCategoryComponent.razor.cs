using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class EditCategoryComponent
    {
        [Parameter]
        public string CategoryId { get; set; }
        private Category category;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            category = new Category();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (int.TryParse(CategoryId, out int Id))
            {
                var cat = this.category = GetCategoryByIdUseCase.Execute(Id);
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
