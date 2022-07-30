using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Factories
{
    using _4.WildFarm.Models.Animals;
    using _4.WildFarm.Models.Animals.Birds;
    using _4.WildFarm.Models.Animals.Mammals;
    using Contracts;
    
    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string type, string name, double weight, string fourthParam, string fifthParam = null)
        {
            Animal animal;
            if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(fourthParam));
            }
            else if (type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(fourthParam));
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, fourthParam);
            }
            else if (type == "Mouse")
            {
                animal = new Mouse(name, weight, fourthParam);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, fourthParam, fifthParam);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, fourthParam, fifthParam);
            }
            else
            {
                throw new ArgumentException("Invalid animal type");
            }
            return animal;
        }
    }
}
