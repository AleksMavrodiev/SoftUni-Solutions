using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Bus : Vehicle
    {
        private readonly double fuelRateModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacuty) : base(fuelQuantity, fuelConsumption, tankCapacuty)
        {

        }

        public override double FuelConsumtionModifier => this.fuelRateModifier;

        

        public override string DriveEmpty(double kilometers)
        {
            double fuelNeeded = kilometers * (this.FuelConsumption - this.FuelConsumtionModifier);
            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {kilometers} km";
            }
        }
    }
}
