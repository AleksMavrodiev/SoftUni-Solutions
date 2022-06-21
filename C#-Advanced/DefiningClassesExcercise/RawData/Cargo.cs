using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private string type;
        private double weight;

        public string Type { get => type; set => type = value; }
        public double Weight { get => weight; set => weight = value; }

        public Cargo(double weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
