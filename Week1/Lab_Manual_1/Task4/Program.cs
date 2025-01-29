using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                Console.WriteLine("Enter a num to sum (-1 to stop taking input)");
                num = int.Parse(Console.ReadLine());    
                sum += num;
            }
            while (num != -1);
            {
                sum = sum + 1; 
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
