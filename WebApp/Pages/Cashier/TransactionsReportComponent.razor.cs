using CoreBusiness.Entities;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages.Cashier
{
    public partial class TransactionsReportComponent
    {
        private string cashierName;
        private DateTime startDate;
        private DateTime endDate;

        private List<Transaction> transactions;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            startDate = DateTime.Today;
            endDate = DateTime.Today;
        }

        private void LoadTransactions()
        {
            transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate).ToList();
        }

        private async Task PrintReport()
        {
            await Runtime.InvokeVoidAsync("print");
        }
    }
}
