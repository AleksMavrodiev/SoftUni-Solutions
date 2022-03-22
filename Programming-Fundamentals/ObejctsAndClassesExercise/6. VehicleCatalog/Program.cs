using System;
using System.Collections.Generic;

namespace _6._VehicleCatalog
{
    class Car
    {
        public Car(string model, string color, double horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            double carHorsePower = 0;
            double truckHorsePower = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                double horsePower = double.Parse(cmdArgs[3]);
                if (type == "truck")
                {
                    Truck newTruck = new Truck(model, color, horsePower);
                    catalogue.Trucks.Add(newTruck);
                }
                else if (type == "car")
                {
                    Car newCar = new Car(model, color, horsePower);
                    catalogue.Cars.Add(newCar);
                }
            }
           
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                bool isFound = false;
                foreach (var car in catalogue.Cars)
                {
                    if (input == car.Model || input == car.Color || input == car.HorsePower.ToString())
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    continue;
                }
                foreach (var truck in catalogue.Trucks)
                {
                    if (input == truck.Model || input == truck.Color || input == truck.HorsePower.ToString())
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        isFound = true;
                    }
                }
            }
            foreach (var car in catalogue.Cars)
            {
                carHorsePower += car.HorsePower;
            }
            foreach (var truck in catalogue.Trucks)
            {
                truckHorsePower += truck.HorsePower;
            }
            double averageHorsePowerCar = carHorsePower / catalogue.Cars.Count;
            double averageCarHorsePower = truckHorsePower / catalogue.Trucks.Count;
            if (catalogue.Cars.Count == 0)
            {
                averageHorsePowerCar = 0;
            }
            if (catalogue.Trucks.Count == 0)
            {
                averageCarHorsePower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCar:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageCarHorsePower:F2}.");
        }
    }
}
