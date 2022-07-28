using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double ModifiedConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override double FuelConsumtionModifier => ModifiedConsumption;

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}
