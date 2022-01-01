using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class AddProductComponent
    {
        private Product product;
        private IEnumerable<Category> categories;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            product = new Product();
            categories = GetCategoriesUseCase.Execute();
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
