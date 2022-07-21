using System;

namespace PizzaCalories
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split(' ');
                string pizzaName = pizzaInfo[1];

                string[] doughInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string flourType = doughInfo[1];
                string technique = doughInfo[2];
                double weight = double.Parse(doughInfo[3]);

                Dough dough = new Dough(flourType, technique, weight);
                Pizza pizza = new Pizza(pizzaName, dough);

                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string toppingName = cmdArgs[1];
                    double toppingWeight = double.Parse(cmdArgs[2]);
                    Topping topping = new Topping(toppingName, toppingWeight);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
