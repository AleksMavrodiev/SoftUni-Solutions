using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double weight;
        private string color;

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, double weigth) : this(model, engine)
        {
            this.Weight = weigth;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight, string color) : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }
    }
}
