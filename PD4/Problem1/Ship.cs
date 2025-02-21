using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Ship
    {
        public string SerialNumber { get; set; }
        public Angle Latitude { get; set; }
        public Angle Longitude { get; set; }

        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            SerialNumber = serialNumber;
            Latitude = latitude;
            Longitude = longitude;
        }

        public void DisplayPosition()
        {
            Console.WriteLine($"Ship is at {Latitude.GetAngleString()} and {Longitude.GetAngleString()}");
        }

        public void DisplaySerialNumber()
        {
            Console.WriteLine($"Ship's serial number is {SerialNumber}");
        }

        public void UpdatePosition()
        {
            Console.WriteLine("Enter New Latitude:");
            Latitude.SetAngle();
            Console.WriteLine("Enter New Longitude:");
            Longitude.SetAngle();
        }
    }
}
