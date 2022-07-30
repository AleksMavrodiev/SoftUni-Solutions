using _4.WildFarm.Core;
using _4.WildFarm.Factories;
using _4.WildFarm.Factories.Contracts;
using System;

namespace _4.WildFarm
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            IFoodFactory foodFactory = new FoodFactory();
            IAnimalFactory animalFactory = new AnimalFactory();

            IEngine engine = new Engine(foodFactory, animalFactory);
            engine.Start();
        }
    }
}
