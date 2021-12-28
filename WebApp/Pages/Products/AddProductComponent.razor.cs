using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class AddProductComponent
    {
        private Product product;
        private List<Category> categories;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            product = new Product();
            categories = GetCategoriesUseCase.Execute().ToList();
        }

        private void AddProduct()
        {
            AddProductUseCase.Execute(product);
            NavigationManager.NavigateTo("/productos");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/Productos");
        }
    }
}
