using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Transaction
    {
        public int TransactionId;
        public string ProductName;
        public int Amount;
        public string Date;
        public string Time;

        public Transaction() { }

        public Transaction(Transaction transaction)
        {
            TransactionId = transaction.TransactionId;      
            ProductName = transaction.ProductName;  
            Amount = transaction.Amount;
            Date = transaction.Date;
            Time = transaction.Time;
        }
    }
}
