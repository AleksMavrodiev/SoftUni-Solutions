using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestNames = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] goingOrNot = Console.ReadLine().Split();
                if (goingOrNot.Length == 3)
                {
                    if (guestNames.Contains(goingOrNot[0]))
                    {
                        Console.WriteLine($"{goingOrNot[0]} is already in the list!");
                        continue;
                    }
                    guestNames.Add(goingOrNot[0]);
                }
                else
                {
                    if (!guestNames.Contains(goingOrNot[00]))
                    {
                        Console.WriteLine($"{goingOrNot[0]} is not in the list!");
                        continue;
                    }
                    guestNames.Remove(goingOrNot[0]);
                }
            }
            for (int j = 0; j < guestNames.Count; j++)
            {
                Console.WriteLine(guestNames[j]);
            }
        }
    }
}
