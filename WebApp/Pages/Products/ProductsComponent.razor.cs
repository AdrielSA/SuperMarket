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
            await Load();
        }

        private void AddProduct()
        {
            NavigationManager.NavigateTo("/agregarproducto");
        }

        private void EditProduct(Product product)
        {
            NavigationManager.NavigateTo($"/editarproducto/{product.ProductId}");
        }

        private async Task DeleteProduct(int productId)
        {
            await DeleteProductUseCase.Delete(productId);
            await Load();
        }

        private async Task Load()
        {
            products = await ProductsUseCase.Execute();
        }
    }
}
