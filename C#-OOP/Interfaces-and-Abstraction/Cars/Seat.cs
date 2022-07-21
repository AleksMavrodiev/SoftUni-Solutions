using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
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
            outout.AppendLine($"{this.Color} Seat {this.Model}");
            outout.AppendLine($"{this.Start()}");
            outout.AppendLine($"{this.Stop()}");
            return outout.ToString().TrimEnd();
        }
    }
}
