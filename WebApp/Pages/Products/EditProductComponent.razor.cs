using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Products
{
    public partial class EditProductComponent
    {
        [Parameter]
        public string ProductId { get; set; }
        private Product product;
        private List<Category> categories;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            categories = GetCategoriesUseCase.Execute().ToList();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (int.TryParse(ProductId, out int Id))
            {
                var prod = this.product = GetProductByIdUseCase.Execute(Id);
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

        private void EditProduct()
        {
            EditProductUseCase.Execute(product);
            NavigationManager.NavigateTo("/productos");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("/productos");
        }
    }
}
