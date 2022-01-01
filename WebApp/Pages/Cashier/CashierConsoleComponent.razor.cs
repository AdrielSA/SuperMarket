using CoreBusiness.Entities;
using System.Threading.Tasks;
using WebApp.Controls;

namespace WebApp.Pages.Cashier
{
    public partial class CashierConsoleComponent
    {
        private Product selectedProduct;
        private string cashierName;
        private TodayTransactionsComponent transactionComponent;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
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
