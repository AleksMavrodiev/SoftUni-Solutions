using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int currPokePower = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            while (currPokePower >= distance)
            {
                currPokePower -= distance;
                pokeCount++;
                if (pokePower / 2 == currPokePower && exhaustionFactor != 0 && currPokePower >= exhaustionFactor)
                {
                    currPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currPokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
