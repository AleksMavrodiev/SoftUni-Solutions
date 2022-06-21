using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires = new Tire[4];

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public Tire[] Tires { get => tires; set => tires = value; }

        public Car(string model, double engineSpeed, double enginePower, double cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tires[0] = new Tire(tire1Pressure, tire1Age);
            this.Tires[1] = new Tire(tire2Pressure, tire2Age);
            this.Tires[2] = new Tire(tire3Pressure, tire3Age);
            this.Tires[3] = new Tire(tire4Pressure, tire4Age);
        }
    }
}
