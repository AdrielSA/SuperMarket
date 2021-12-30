using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStoreInterfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> Get(string cashierName);

        Task<IEnumerable<Transaction>> GetByDay(string cashierName, DateTime date);

        Task<IEnumerable<Transaction>> Search(string cashierName, DateTime startDate, DateTime endDate);

        Task Save(string cashierName, int productId, string productName, double price, int beforeQty, int qty);
    }
}
