using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string Name { 
            get 
            {
                return this.name;    
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(this.Name), "Name cannot be null or whitespace");
                }
                this.name = value;
            }  
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(this.Age), "Age must be positive number!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(this.Gender), "Gender cannot be null or whitespace");
                }
                this.gender = value;
            }
        }

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{this.GetType().Name}");
            output.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            output.AppendLine($"{this.ProduceSound()}");
            return output.ToString();
        }
    }
}
