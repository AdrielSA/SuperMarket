using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controls
{
    public partial class SelectProductForSellingComponent
    {
        [Parameter]
        public EventCallback<Product> ProductSelected { get; set; }

        private IEnumerable<Category> categories;
        private IEnumerable<Product> productsInCategory;
        private int selectedCategoryId;
        private int selectedProductId;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            categories = await GetCategoriesUseCase.Execute();
        }

        private int SelectedCategoryId
        {
            get
            {
                return selectedCategoryId;
            }
            set
            {
                selectedCategoryId = value;
                productsInCategory = GetProductsByCategoryId.Execute(value).Result;
                SelectProduct(null);
                StateHasChanged();
            }
        }

        private void SelectProduct(Product product)
        {
            ProductSelected.InvokeAsync(product);
            if (product != null) selectedProductId = product.ProductId;
        }
    }
}
