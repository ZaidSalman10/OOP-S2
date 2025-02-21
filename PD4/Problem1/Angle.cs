using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Angle
    {
        public int Degrees { get; set; }
        public float Minutes { get; set; }
        public char Direction { get; set; }

        public Angle(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }

        public void SetAngle()
        {
            Console.Write("Enter Degrees: ");
            Degrees = int.Parse(Console.ReadLine());

            Console.Write("Enter Minutes: ");
            Minutes = float.Parse(Console.ReadLine());

            Console.Write("Enter Direction (N, S, E, W): ");
            Direction = Console.ReadLine()[0];
        }

        public string GetAngleString()
        {
            return $"{Degrees}°{Minutes}’ {Direction}";
        }
    }
}
