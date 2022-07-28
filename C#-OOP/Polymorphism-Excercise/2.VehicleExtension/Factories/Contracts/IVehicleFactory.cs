using _01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Factories.Contracts
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string vehicleType, double fuelQuantuty, double fuelConsumption, double tankCapacity);
    }
}
