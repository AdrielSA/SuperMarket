﻿using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;

namespace DataStore.InMemory.ImMemoryRepositories
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private readonly List<Transaction> transactions;

        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions;
            }
            else
            {
                return transactions.Where(x => 
                string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
;           }
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions.Where(x => x.TimeStamp.Date == date.Date);
            }
            else
            {
                return transactions.Where(x =>
                string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                x.TimeStamp.Date == date.Date);
            }
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
        {
            var transactionId = 0;
            if (transactions != null && transactions.Count > 0)
            {
                var maxId = transactions.Max(x => x.TransactionId);
                transactionId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }

            transactions.Add(new Transaction 
            {
                TransactionId = transactionId,
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                SoldQty = soldQty,
                BeforeQty = beforeQty,
                CashierName = cashierName
            });
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions.Where(
                    x => x.TimeStamp.Date >= startDate.Date && 
                    x.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
            else
            {
                return transactions.Where(
                    x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) && 
                    x.TimeStamp.Date >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
        }
    }
}
