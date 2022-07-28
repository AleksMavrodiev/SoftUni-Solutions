using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }

        string Drive(double kilometers);

        void Refuel(double liters);
    }
}
