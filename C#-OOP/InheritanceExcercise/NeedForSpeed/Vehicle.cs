using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        private double fuelConsumption;
        private double fuel;
        private int horsePower;

        

        public virtual double FuelConsumption { get => fuelConsumption; set => fuelConsumption = DefaultFuelConsumption; }
        public double Fuel { get => fuel; set => fuel = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }

        

        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
            
        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
