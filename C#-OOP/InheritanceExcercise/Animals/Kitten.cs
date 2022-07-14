using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Kitten : Animal
    {
        private const string GenderDefault = "female";

        public Kitten(string name, int age) : base(name, age, GenderDefault)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
