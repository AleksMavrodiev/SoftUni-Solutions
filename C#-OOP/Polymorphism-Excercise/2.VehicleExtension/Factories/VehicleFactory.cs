
namespace _01.Vehicles.Factories
{
    using _01.Vehicles.Models;
    using Contracts;
    using System;

    public class VehicleFactory : IVehicleFactory
    {

        public Vehicle CreateVehicle(string vehicleType, double fuelQuantuty, double fuelConsumption, double tankCapacity)
        {
            Vehicle vehicle;
            
            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantuty, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantuty, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus")
            {
                vehicle = new Bus(fuelQuantuty, fuelConsumption, tankCapacity);
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type");
            }
            return vehicle;
        }
    }
}
