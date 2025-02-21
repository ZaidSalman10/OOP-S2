using System;
using System.Collections.Generic;

namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            List<Ship> ships = new List<Ship>();
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add Ship\n2. View Ship Position\n3. View Ship Serial Number\n4. Change Ship Position\n5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter Ship Serial Number: ");
                    string serialNumber = Console.ReadLine();
                    Console.WriteLine("Enter Ship Latitude:");
                    Angle latitude = new Angle(0, 0.0f, 'N');
                    latitude.SetAngle();
                    Console.WriteLine("Enter Ship Longitude:");
                    Angle longitude = new Angle(0, 0.0f, 'E');
                    longitude.SetAngle();

                    ships.Add(new Ship(serialNumber, latitude, longitude));
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Ship Serial Number to find its position: ");
                    string serialNumber = Console.ReadLine();
                    Ship foundShip = ships.Find(ship => ship.SerialNumber == serialNumber);
                    if (foundShip != null)
                    {
                        foundShip.DisplayPosition();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter Latitude: ");
                    string lat = Console.ReadLine();
                    Console.Write("Enter Longitude: ");
                    string lon = Console.ReadLine();
                    Ship foundShip = ships.Find(ship => ship.Latitude.GetAngleString() == lat && ship.Longitude.GetAngleString() == lon);
                    if (foundShip != null)
                    {
                        foundShip.DisplaySerialNumber();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter Ship Serial Number to change its position: ");
                    string serialNumber = Console.ReadLine();
                    Ship foundShip = ships.Find(ship => ship.SerialNumber == serialNumber);
                    if (foundShip != null)
                    {
                        foundShip.UpdatePosition();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
