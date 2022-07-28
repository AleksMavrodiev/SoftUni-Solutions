
namespace _01.Vehicles.Core
{
    using Models;
    using System;

    public class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;

        public Engine(Vehicle car, Vehicle truck)
        {
            this.car = car;
            this.truck = truck;
        }

        public void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
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
                }
            }
            Console.WriteLine(this.car);
            Console.WriteLine(this.truck);
        }
    }
}
