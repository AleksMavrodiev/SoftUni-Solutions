using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._OrderByAge
{
    class Person 
    {
        public Person(string firstName, string ID, int age)
        {
            this.FirstName = firstName;
            this.ID = ID;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                bool isSame = false;
                string[] cmdArgs = input.Split();
                string name = cmdArgs[0];
                string ID = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                foreach (Person person in persons)
                {
                    if (person.ID == ID)
                    {
                        person.FirstName = name;
                        person.Age = age;
                        isSame = true;
                    }
                }
                if (isSame)
                {
                    continue;
                }
                Person newPerson = new Person(name, ID, age);
                persons.Add(newPerson);
            }
            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
