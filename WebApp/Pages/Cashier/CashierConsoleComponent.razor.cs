using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Controls;

namespace WebApp.Pages.Cashier
{
    public partial class CashierConsoleComponent
    {
        private Product selectedProduct;
        private string cashierName;
        private TodayTransactionsComponent transactionComponent;

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                SellProduct();
            }
        }

        private void SelectedProduct(Product product)
        {
            selectedProduct = product;
        }

        private void SellProduct()
        {
            transactionComponent.LoadTransactions(cashierName);
        }
    }
}
