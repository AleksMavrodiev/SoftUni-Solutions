using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Food_Shortage
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public int Food { get; private set; }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
