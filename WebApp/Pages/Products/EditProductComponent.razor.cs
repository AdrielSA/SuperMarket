using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class EditProductComponent
    {
        [Parameter]
        public string ProductId { get; set; }
        private Product product;
        private IEnumerable<Category> categories;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            categories = await GetCategoriesUseCase.Execute();
        }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            if (int.TryParse(ProductId, out int Id))
            {
                var prod = this.product = await GetProductByIdUseCase.Execute(Id);
                product = new Product
                {
                    ProductId = prod.ProductId,
                    CategoryId = prod.CategoryId,
                    Name = prod.Name,
                    Quantity = prod.Quantity,
                    Price = prod.Price
                };
            }
        }

        private async Task EditProduct()
        {
            await EditProductUseCase.Execute(product);
            NavigationManager.NavigateTo("/productos");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/productos");
        }
    }
}
