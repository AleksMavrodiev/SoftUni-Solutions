 namespace _01.Vehicles
{
    using System;
    using Factories;
    using Factories.Contracts;
    using Models;
    using Core;
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            double carFuel = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            string[] truckInfo = Console.ReadLine().Split();
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);

            IVehicleFactory factory = new VehicleFactory();
            Vehicle car = factory.CreateVehicle("Car", carFuel, carConsumption);
            Vehicle truck = factory.CreateVehicle("Truck", truckFuel, truckConsumption);

            IEngine engine = new Engine(car, truck);
            engine.Start();
        }
    }
}
