using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side of a square: ");
            float length = float.Parse(Console.ReadLine());
            float area = length * length;
            Console.WriteLine("Area of Square == " + area + " sq.unit");
        }
    }
}
