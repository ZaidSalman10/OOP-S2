using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int num = arr[0];
            for (int i = 1; i < 3; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    num = arr[i];
                }
            }
            Console.WriteLine("Largest Number: " + num);
        }
    }
}
