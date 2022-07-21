using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Border_Control
{
    public class Citizen : IIdentifiable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}
