using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Border_Control
{
    public class Pet : IBirthable
    {
        public string Name { get; set; }

        public string BirthDate { get; private set; }

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
    }
}
