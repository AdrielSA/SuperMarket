using CoreBusiness.Entities;
using DataStore.SQL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Transaction>> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return await _context.Transactions.ToListAsync();
            }
            else
            {
                var trans = _context.Transactions.Where(x => 
                x.CashierName.ToLower() == cashierName.ToLower()).AsQueryable();
                return await trans.ToListAsync();
            }
        }

        public async Task<IEnumerable<Transaction>> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                var trans = _context.Transactions.Where(x => x.TimeStamp.Date == date.Date).AsQueryable();
                return await trans.ToListAsync();
            }
            else
            {
                var trans =  _context.Transactions.Where(x =>
                x.CashierName.ToLower() == cashierName.ToLower() &&
                x.TimeStamp.Date == date.Date).AsQueryable();
                return await trans.ToListAsync();
            }
        }

        public async Task Save(
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

            await _context.Transactions.AddAsync(tran);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                var trans = _context.Transactions.Where(
                    x => x.TimeStamp.Date >= startDate.Date &&
                    x.TimeStamp <= endDate.Date.AddDays(1).Date).AsQueryable();
                return await trans.ToListAsync();
            }
            else
            {
                var trans = _context.Transactions.Where(
                    x => x.CashierName.ToLower() == cashierName.ToLower() &&
                    x.TimeStamp.Date >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date).AsQueryable();
                return await trans.ToListAsync();
            }
        }
    }
}
