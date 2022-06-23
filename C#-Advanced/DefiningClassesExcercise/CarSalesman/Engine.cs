using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;

        public string Model { get => model; set => model = value; }
        public double Power { get => power; set => power = value; }
        public double Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, double power, double displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, double power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, double power, double displacement, string efficiency) : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
