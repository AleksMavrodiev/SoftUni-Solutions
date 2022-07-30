using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Factories.Contracts
{
    using Models.Animals;
    public interface IAnimalFactory
    {
        Animal CreateAnimal(string type, string name, double weight, string fourthParam, string fifthParam = null);
    }
}
