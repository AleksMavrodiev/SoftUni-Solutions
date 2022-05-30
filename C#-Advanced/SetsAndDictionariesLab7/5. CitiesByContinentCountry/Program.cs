using System;
using System.Collections.Generic;

namespace _5._CitiesByContinentCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                AddCity(continents, continent, country, city);
            }
            PrintContrinents(continents);
        }

        static void PrintContrinents(Dictionary<string, Dictionary<string, List<string>>> continents)
        {
            foreach (var continent in continents.Keys)
            {
                Console.WriteLine(continent + ":");
                foreach (var country in continents[continent].Keys)
                {
                    Console.Write(" " + country + " -> ");
                    List<string> allCities = continents[continent][country];
                    Console.WriteLine(string.Join(", ", allCities));
                }
            }
        }

        static void AddCity(Dictionary<string, Dictionary<string, List<string>>> continents, string continent, string country, string city)
        {
            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent, new Dictionary<string, List<string>>());
            }
            Dictionary<string, List<string>> contries = continents[continent];
            if (!contries.ContainsKey(country))
            {
                contries.Add(country, new List<string>());
            }
            contries[country].Add(city);
        }
    }
}
