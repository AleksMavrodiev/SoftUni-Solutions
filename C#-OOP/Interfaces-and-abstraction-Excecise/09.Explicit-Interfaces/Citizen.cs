using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Explicit_Interfaces
{
    public class Citizen : IResident, IPerson
    {
        public string Name { get; private set; }

        public string Country { get; private set; }

        public int Age { get; private set; }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        void IPerson.GetName()
        {
            Console.WriteLine(this.Name);
        }

        void IResident.GetName()
        {
            Console.WriteLine($"Mr/Ms/Mrs {this.Name}");
        }
    }
}
