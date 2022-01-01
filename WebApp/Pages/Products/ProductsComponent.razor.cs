using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class ProductsComponent
    {
        private IEnumerable<Product> products;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Load();
        }

        private void AddProduct()
        {
            NavigationManager.NavigateTo("/agregarproducto");
        }

        private void EditProduct(Product product)
        {
            NavigationManager.NavigateTo($"/editarproducto/{product.ProductId}");
        }

        private void DeleteProduct(int productId)
        {
            DeleteProductUseCase.Delete(productId);
            Load();
        }

        private void Load()
        {
            products = ProductsUseCase.Execute();
        }
    }
}
