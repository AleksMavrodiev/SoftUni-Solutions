﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder outout = new StringBuilder();
            outout.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
            outout.AppendLine($"{this.Start()}");
            outout.AppendLine($"{this.Stop()}");
            return outout.ToString().TrimEnd();
        }
    }
}
