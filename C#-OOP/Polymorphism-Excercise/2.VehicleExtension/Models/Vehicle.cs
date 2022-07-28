namespace _01.Vehicles.Models
{
    using Contracts;
    using System;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        private Vehicle()
        {
            this.FuelConsumtionModifier = 0;
        }
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity) : this()
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            protected set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            protected set
            {
                fuelConsumption = value + this.FuelConsumtionModifier;
            }
        }

        public virtual double FuelConsumtionModifier { get; }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }

        public string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;
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

        public virtual void Refuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += liters;
        }

        public virtual string DriveEmpty(double kilometers)
        {
            return String.Empty;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
