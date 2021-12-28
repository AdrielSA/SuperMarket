using CoreBusiness.Entities;
using DataStore.SQL.Context;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.ToList();
            }
            else
            {
                return _context.Transactions.Where(x => x.CashierName.ToLower() == cashierName.ToLower());
            }
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            }
            else
            {
                return _context.Transactions.Where(x =>
                x.CashierName.ToLower() == cashierName.ToLower() &&
                x.TimeStamp.Date == date.Date);
            }
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
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

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return _context.Transactions.Where(
                    x => x.TimeStamp.Date >= startDate.Date &&
                    x.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
            else
            {
                return _context.Transactions.Where(
                    x => x.CashierName.ToLower() == cashierName.ToLower() &&
                    x.TimeStamp.Date >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
        }
    }
}
