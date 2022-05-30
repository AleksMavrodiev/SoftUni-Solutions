using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(", ");
                string action = cmdArgs[0];
                string carNumber = cmdArgs[1];
                if (action == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (action == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }
            if (!cars.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
