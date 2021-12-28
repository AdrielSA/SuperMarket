using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Categories
{
    public partial class AddCategoryComponent
    {
        private Category category;

        protected override void OnInitialized()
        {
            base.OnInitialized();
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
