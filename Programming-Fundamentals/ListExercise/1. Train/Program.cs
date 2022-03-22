using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    int wagonToAdd = int.Parse(action[1]);
                    wagons.Add(wagonToAdd);
                }
                else
                {
                    int passengersToAdd = int.Parse(action[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToAdd <= wagonCapacity)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
