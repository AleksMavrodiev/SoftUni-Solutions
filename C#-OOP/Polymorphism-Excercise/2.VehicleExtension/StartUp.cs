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
            double tankCapacity = double.Parse(carInfo[3]);
            string[] truckInfo = Console.ReadLine().Split();
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);
            string[] busInfo = Console.ReadLine().Split();
            double busFuel = double.Parse(busInfo[1]);
            double busConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            IVehicleFactory factory = new VehicleFactory();
            Vehicle car = factory.CreateVehicle("Car", carFuel, carConsumption, tankCapacity);
            Vehicle truck = factory.CreateVehicle("Truck", truckFuel, truckConsumption, truckTankCapacity);
            Vehicle bus = factory.CreateVehicle("Bus", busFuel, busConsumption, busTankCapacity);

            IEngine engine = new Engine(car, truck, bus);
            engine.Start();
        }
    }
}
