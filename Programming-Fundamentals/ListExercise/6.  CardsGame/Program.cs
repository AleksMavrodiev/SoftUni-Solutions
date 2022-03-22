using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.__CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; Math.Min(firstDeck.Count, secondDeck.Count) > 0; i++)
            {
                int firstCard = firstDeck[0];
                firstDeck.RemoveAt(0);
                int secondCard = secondDeck[0];
                secondDeck.RemoveAt(0);
                if (firstCard > secondCard)
                {
                    firstDeck.Add(firstCard);
                    firstDeck.Add(secondCard);
                }
                else if (firstCard < secondCard)
                {
                    secondDeck.Add(secondCard);
                    secondDeck.Add(firstCard);
                }
                else if(firstCard == secondCard)
                {
                    continue;
                }
            }
            if (firstDeck.Sum() > secondDeck.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
