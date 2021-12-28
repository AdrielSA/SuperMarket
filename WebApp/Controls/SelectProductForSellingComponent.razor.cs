using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controls
{
    public partial class SelectProductForSellingComponent
    {
        [Parameter]
        public EventCallback<Product> ProductSelected { get; set; }

        private List<Category> categories;
        private List<Product> productsInCategory;
        private int selectedCategoryId;
        private int selectedProductId;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            categories = GetCategoriesUseCase.Execute().ToList();
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
                productsInCategory = GetProductsByCategoryId.Execute(value).ToList();
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
