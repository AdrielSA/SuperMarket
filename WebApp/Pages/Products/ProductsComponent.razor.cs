using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class ProductsComponent
    {
        private List<Product> products;

        protected override void OnInitialized()
        {
            base.OnInitialized();
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
            products = ProductsUseCase.Execute().ToList();
        }
    }
}
