
namespace _01.Vehicles.Core
{
    using Models;
    using System;

    public class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;
        private readonly Vehicle bus;

        public Engine(Vehicle car, Vehicle truck, Vehicle bus)
        {
            this.car = car;
            this.truck = truck;
            this.bus = bus;
        }

        public void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split();
                    string action = input[0];
                    string vehicleType = input[1];
                    double methodParam = double.Parse(input[2]);

                    if (action == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            Console.WriteLine(this.car.Drive(methodParam));
                        }
                        else if (vehicleType == "Truck")
                        {
                            Console.WriteLine(this.truck.Drive(methodParam));
                        }
                        else if (vehicleType == "Bus")
                        {
                            Console.WriteLine(this.bus.Drive(methodParam));
                        }
                    }
                    else if (action == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            this.car.Refuel(methodParam);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.truck.Refuel(methodParam);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.bus.Refuel(methodParam);
                        }
                    }
                    else if (action == "DriveEmpty")
                    {
                        Console.WriteLine(this.bus.DriveEmpty(methodParam));
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine(this.car);
            Console.WriteLine(this.truck);
            Console.WriteLine(this.bus);
        }
    }
}
