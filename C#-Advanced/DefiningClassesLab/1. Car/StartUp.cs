using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> complectTire = new List<Tire[]>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] cmdArgs = command.Split();
                int firstTireYear = int.Parse(cmdArgs[0]);
                double firstTirePressure = double.Parse(cmdArgs[1]);
                int secindTireYear = int.Parse(cmdArgs[2]);
                double secindTirePressure = double.Parse(cmdArgs[3]);
                int thirdTireYear = int.Parse(cmdArgs[4]);
                double thirdTirePressure = double.Parse(cmdArgs[5]);
                int fourthTireYear = int.Parse(cmdArgs[6]);
                double fourthTirePressure = double.Parse(cmdArgs[7]);
                complectTire.Add(new Tire[4] { new Tire(firstTireYear, firstTirePressure), new Tire(secindTireYear, secindTirePressure), new Tire(thirdTireYear, thirdTirePressure), new Tire(fourthTireYear, fourthTirePressure) });

            }
            string engineSpecs = string.Empty;
            List<Engine> engines = new List<Engine>();
            while ((engineSpecs = Console.ReadLine()) != "Engines done")
            {
                string[] cmdArgs = engineSpecs.Split();
                int horsePower = int.Parse(cmdArgs[0]);
                double cubicCapacity = double.Parse(cmdArgs[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }
            string makingCars = string.Empty;
            List<Car> cars = new List<Car>();
            while ((makingCars = Console.ReadLine()) != "Show special")
            {
                string[] cmdArgs = makingCars.Split();
                string make = cmdArgs[0];
                string model = cmdArgs[1];
                int year = int.Parse(cmdArgs[2]);
                double fuelQuantity = double.Parse(cmdArgs[3]);
                double fuelConsumption = double.Parse(cmdArgs[4]);
                int tiresIndex = int.Parse(cmdArgs[6]);
                int engineIndex = int.Parse(cmdArgs[5]);
                var tires = complectTire[tiresIndex];
                var engine = engines[engineIndex];
                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                cars.Add(newCar);
            }
            List<Car> specialCars = new List<Car>();
            foreach (var car in cars)
            {
                double pressureSUm = 0;
                foreach (var tire in car.Tires)
                {
                    pressureSUm += tire.Pressure;
                }
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && pressureSUm >= 9 && pressureSUm <= 10)
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }
            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsepowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
