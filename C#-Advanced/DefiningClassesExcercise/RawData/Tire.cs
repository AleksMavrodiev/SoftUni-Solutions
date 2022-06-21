using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private int age;
        private double pressure;

        public int Age { get => age; set => age = value; }
        public double Pressure { get => pressure; set => pressure = value; }

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
            
        }
    }
}
