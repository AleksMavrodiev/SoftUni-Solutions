using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    internal class Program
    {
        private static List<string> nonStaticPeople;
        private static string[] people;
        private static bool[] locked;
        static void Main(string[] args)
        {
            nonStaticPeople = Console.ReadLine().Split(", ").ToList();
            people = new string[nonStaticPeople.Count];
            locked = new bool[nonStaticPeople.Count];
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "generate")
                {
                    break;
                }

                var parts = line.Split(" - ");
                var name = parts[0];
                var seat = int.Parse(parts[1]) - 1;

                people[seat] = name;
                locked[seat] = true;
                nonStaticPeople.Remove(name);
            }

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= nonStaticPeople.Count)
            {
                PrintPermutation();
                return;
            }
            Permute(index + 1);

            for (int i = index + 1; i < nonStaticPeople.Count; i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }

        }

        private static void PrintPermutation()
        {
            var peopleIndex = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < people.Length; i++)
            {
                if (locked[i])
                {
                    sb.Append($"{people[i]} ");
                }
                else
                {
                    sb.Append($"{nonStaticPeople[peopleIndex++]} ");
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void Swap(int first, int second)
        {
            var temp = nonStaticPeople[first];
            nonStaticPeople[first] = nonStaticPeople[second];
            nonStaticPeople[second] = temp;
        }
    }
}
