using System;
namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            int a, b, function = 0;
            Console.Write("Input Number 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input Number 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Choose the operation (1-4): ");
            function = int.Parse(Console.ReadLine());
            if (function == 1)
            {
                op.Add(a, b);            
            }
            else if (function == 2)
            {
                op.Sub(a, b);
            }
            else if (function == 3)
            {
                op.Mul(a, b);
            }
            else if (function == 4)
            {
                op.Div(a, b);
            }
            else 
            {
                Console.WriteLine("Wrong Option Selected...");
            }
            Console.ReadKey();
        }
    }
}
