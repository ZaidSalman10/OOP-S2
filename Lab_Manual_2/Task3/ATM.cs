using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ATM
    {
        int i, balance = 1000;
        double[] transaction = new double[100];
        public void deposit(int amount)
        {
            balance = balance + amount;
        }
        public void withdraw(int amount)
        {
            balance = balance - amount;
        }
        public void show()
        {
            Console.WriteLine("Total Balance: " + balance);
        }
        public void save(int amount, int option)
        {
            
        }
    }
}
