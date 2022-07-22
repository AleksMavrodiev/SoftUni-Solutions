using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Food_Shortage
{
    public class Citizen : IIdentifiable, IBuyer, IBirthable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public int Food { get; private set; }

        public string BirthDate { get; private set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Food = 0;
            BirthDate = birthDate;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
