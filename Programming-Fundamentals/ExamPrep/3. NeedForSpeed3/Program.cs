using System;
using System.Collections.Generic;

namespace _3._NeedForSpeed3
{
    class Car
    {
        public Car(int fuel, int miles)
        {
            this.Fuel = fuel;
            this.Miles = miles;
        }
        public int Fuel { get; set; }
        public int Miles { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < numberCars; i++)
            {
                string car = Console.ReadLine();
                string[] carParameters = car.Split('|');
                string name = carParameters[0];
                int miles = int.Parse(carParameters[1]);
                int fuel = int.Parse(carParameters[2]);
                cars.Add(name, new Car(fuel, miles));
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Drive")
                {
                    string carName = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);
                    if (cars[carName].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName].Fuel -= fuel;
                        cars[carName].Miles += distance;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[carName].Miles >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            cars.Remove(carName);
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    string carName = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);
                    int oldFuel = cars[carName].Fuel;
                    cars[carName].Fuel += fuel;
                    if (cars[carName].Fuel > 75)
                    {
                        cars[carName].Fuel = 75;
                    }
                    Console.WriteLine($"{carName} refueled with {cars[carName].Fuel - oldFuel} liters");
                }
                else if (action == "Revert")
                {
                    string carName = cmdArgs[1];
                    int kilometers = int.Parse(cmdArgs[2]);
                    cars[carName].Miles -= kilometers;
                    if (cars[carName].Miles >= 10000)
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        cars[carName].Miles = 10000;
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Miles} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
