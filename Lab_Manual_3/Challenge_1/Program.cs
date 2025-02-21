using System;
namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType Clock1 = new ClockType(9, 15, 30);
            ClockType Clock2 = new ClockType(14, 45, 15);
            Console.Write("Morning Clock Time: ");
            Clock1.DisplayTime();
            Console.WriteLine($"Elapsed Seconds: {Clock1.GetElapsedSeconds()}");
            Console.WriteLine($"Remaining Seconds: {Clock1.GetRemainingSeconds()}");
            Console.Write("Afternoon Clock Time: ");
            Clock2.DisplayTime();
            Console.WriteLine($"Elapsed Seconds: {Clock2.GetElapsedSeconds()}");
            Console.WriteLine($"Remaining Seconds: {Clock2.GetRemainingSeconds()}");
            Console.WriteLine($"Time Difference between Morning and Afternoon Clocks: " + $"{Clock1.GetTimeDifference(Clock2)} seconds");
            Console.WriteLine("Press any Key To Exit");
            Console.ReadKey();
        }
    }
}
