using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string element;
        private double health;

        public string Name { get => name; set => name = value; }
        public string Element { get => element; set => element = value; }
        public double Health { get => health; set => health = value; }

        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
