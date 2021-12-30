using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Transactions
{
    public interface IGetTransactionsUseCase
    {
        Task<IEnumerable<Transaction>> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}
