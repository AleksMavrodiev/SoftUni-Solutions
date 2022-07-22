using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Food_Shortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> feeders = new List<Citizen>();
            List<Rebel> cholers = new List<Rebel>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string namea = input[0];
                int age = int.Parse(input[1]);
                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthYear = input[3];
                    Citizen person = new Citizen(namea, age, id, birthYear);
                    feeders.Add(person);
                }
                else
                {
                    string groupName = input[2];
                    Rebel rebel = new Rebel(namea, age, groupName);
                    cholers.Add(rebel);
                }
            }

            string name = string.Empty;
            while ((name = Console.ReadLine()) != "End")
            {
                Citizen citizen = feeders.FirstOrDefault(x => x.Name == name);
                Rebel rebel = cholers.FirstOrDefault(x => x.Name == name);
                if (citizen != null)
                {
                    citizen.BuyFood();
                }
                if (rebel != null)
                {
                    rebel.BuyFood();
                }
            }

            Console.WriteLine($"{feeders.Sum(x => x.Food) + cholers.Sum(y => y.Food)}");
        }
    }
}
