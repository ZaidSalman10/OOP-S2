using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum = 0;
            while (num != -1)
            {
                Console.WriteLine("Enter a number to sum (-1 to stop taking input): ");
                num = int.Parse(Console.ReadLine());
                sum = num + sum;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
