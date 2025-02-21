using System;
namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Transaction T = new Transaction();
            T.TransactionId = 1;
            T.ProductName = "Test";
            T.Amount = 100;
            T.Date = "26 / 09 / 2006";
            T.Time = "12pm";

            Transaction t = new Transaction(T);
        }
    }
}