using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colour = input[0];
                string[] clothes = input[1].Split(",");
                AddClothes(wardrobe, colour, clothes);
            }
            string[] searching = Console.ReadLine().Split();
            string searchedColour = searching[0];
            string searchedClothes = searching[1];
            foreach (var cloth in wardrobe)
            {
                Console.WriteLine($"{cloth.Key} clothes:");
                foreach (var piece in cloth.Value)
                {
                    if (cloth.Key == searchedColour && piece.Key == searchedClothes)
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value}");
                    }
                }
            }
        }

        static void AddClothes(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string[] clothes)
        {
            if (!wardrobe.ContainsKey(colour))
            {
                wardrobe.Add(colour, new Dictionary<string, int>());
            }
            Dictionary<string, int> kleidung = wardrobe[colour];
            for (int i = 0; i < clothes.Length; i++)
            {
                if (!kleidung.ContainsKey(clothes[i]))
                {
                    kleidung.Add(clothes[i], 1);
                }
                else
                {
                    kleidung[clothes[i]]++;
                }
            }
        }
    }
}
