using CoreBusiness.Entities;
using DataStore.SQL.Context;
using System;
using System.Linq;
using UseCases.DataStoreInterfaces;

namespace DataStore.SQL.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext _context;

        public TransactionRepository(MarketContext context)
        {
            _context = context;
        }

        public IQueryable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.AsQueryable();
            }
            else
            {
                return _context.Transactions.Where(x => 
                x.CashierName.ToLower() == cashierName.ToLower()).AsQueryable();
            }
        }

        public IQueryable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.Where(x => x.TimeStamp.Date == date.Date).AsQueryable();
            }
            else
            {
                return _context.Transactions.Where(x =>
                x.CashierName.ToLower() == cashierName.ToLower() &&
                x.TimeStamp.Date == date.Date).AsQueryable();
            }
        }

        public void Save(
            string cashierName, 
            int productId, 
            string productName, 
            double price, 
            int beforeQty, 
            int soldQty)
        {
            var tran = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                SoldQty = soldQty,
                BeforeQty = beforeQty,
                CashierName = cashierName
            };

            _context.Transactions.Add(tran);
            _context.SaveChanges();
        }

        public IQueryable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.Where(
                    x => x.TimeStamp.Date >= startDate.Date &&
                    x.TimeStamp <= endDate.Date.AddDays(1).Date).AsQueryable();
            }
            else
            {
                return _context.Transactions.Where(
                    x => x.CashierName.ToLower() == cashierName.ToLower() &&
                    x.TimeStamp.Date >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date).AsQueryable();
            }
        }
    }
}
