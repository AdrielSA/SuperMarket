using CoreBusiness.Entities;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Cashier
{
    public partial class TransactionsReportComponent
    {
        private string cashierName;
        private DateTime startDate;
        private DateTime endDate;

        private IEnumerable<Transaction> transactions;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            startDate = DateTime.Today;
            endDate = DateTime.Today;
        }

        private async Task LoadTransactions()
        {
            transactions = await GetTransactionsUseCase.Execute(cashierName, startDate, endDate);
        }

        private async Task PrintReport()
        {
            await Runtime.InvokeVoidAsync("print");
        }
    }
}
