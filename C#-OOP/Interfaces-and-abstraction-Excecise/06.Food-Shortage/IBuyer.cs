using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Food_Shortage
{
    public interface IBuyer
    {
        public int Food { get;}
        public void BuyFood();
    }
}
