﻿using CoreBusiness.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controls
{
    public partial class SellProductComponent
    {
        [Parameter]
        public string CashierName { get; set; }

        [Parameter]
        public Product SelectedProduct { get; set; }

        [Parameter]
        public EventCallback<Product> ProductSold { get; set; }

        private string errorMessage;
        private Product productToSell;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (SelectedProduct != null)
            {
                productToSell = new Product()
                {
                    ProductId = SelectedProduct.ProductId,
                    Name = SelectedProduct.Name,
                    CategoryId = SelectedProduct.CategoryId,
                    Price = SelectedProduct.Price,
                    Quantity = 0
                };
            }
        }

        private void SellProduct()
        {
            if (string.IsNullOrWhiteSpace(CashierName))
            {
                errorMessage = "Falta el nombre del cajero/a.";
                return;
            }
            var prod = GetProductByIdUseCase.Execute(productToSell.ProductId);
            if (productToSell.Quantity <= 0)
            {
                errorMessage = "La cantidad debe ser mayor a cero (0).";
            }
            else if (prod.Quantity >= productToSell.Quantity)
            {
                ProductSold.InvokeAsync(productToSell);
                errorMessage = string.Empty;
                SellProductUseCase.Execute(CashierName ,productToSell.ProductId, productToSell.Quantity.Value);
            }
            else
            {
                errorMessage = $"Se ha superado la cantidad restante.";
            }
        }
    }
}
