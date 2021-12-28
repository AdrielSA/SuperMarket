using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public DateTime TimeStamp { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } // En case de que el nombre del producto cambie

        public double Price { get; set; }

        public int BeforeQty { get; set; }

        public int SoldQty { get; set; }

        public string CashierName { get; set; }
    }
}
