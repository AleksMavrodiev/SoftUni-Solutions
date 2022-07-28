namespace _01.Vehicles.Models
{
    using Contracts;
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        private Vehicle()
        {
            this.FuelConsumtionModifier = 0;
        }
        protected Vehicle(double fuelQuantity, double fuelConsumption) : this()
        {
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
                fuelQuantity = value;
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
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
