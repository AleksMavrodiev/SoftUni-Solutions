using System.Collections.Generic;

namespace Animals
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string animalType = string.Empty;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    Animal animal = null;
                    string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string gender = cmdArgs[2];
                    if (animalType == "Dog")
                    {
                        animal = new Dog(name, age, gender);
                    }
                    else if (animalType == "Frog")
                    {
                        animal = new Frog(name, age, gender);
                    }
                    else if (animalType == "Cat")
                    {
                        animal = new Cat(name, age, gender);
                    }
                    else if (animalType == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (animalType == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }
                    animals.Add(animal);
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
