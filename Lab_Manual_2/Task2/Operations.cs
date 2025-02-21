using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Operations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));  
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Quotient: " + (a / b));
        }
    }
}
