using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Factories.Contracts
{
    using Models.Foods;
    public interface IFoodFactory
    {
        Food CreateFood(string type, int quantity);

    }
}
