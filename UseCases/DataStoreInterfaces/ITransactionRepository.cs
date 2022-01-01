using CoreBusiness.Entities;
using System;
using System.Linq;

namespace UseCases.DataStoreInterfaces
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Get(string cashierName);

        IQueryable<Transaction> GetByDay(string cashierName, DateTime date);

        IQueryable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);

        void Save(string cashierName, int productId, string productName, double price, int beforeQty, int qty);
    }
}
