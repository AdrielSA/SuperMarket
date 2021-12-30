using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Transactions
{
    public interface IGetTodayTransactionsUseCase
    {
        Task<IEnumerable<Transaction>> Execute(string cashierName);
    }
}
