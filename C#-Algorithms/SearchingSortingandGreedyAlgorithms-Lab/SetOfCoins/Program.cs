﻿using System;
using System.Linq;
using System.Text;

namespace SetOfCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(x => x).ToArray();
            var target = int.Parse(Console.ReadLine());
            var counter = 0;
            var coinsIndex = 0;
            var sb = new StringBuilder();
            while (target > 0 && coinsIndex < coins.Length)
            {
                var currentCoin = coins[coinsIndex++];
                var coinsCount = target / currentCoin;
                if (coinsCount > 0)
                {
                    counter += coinsCount;
                    target -= currentCoin * coinsCount;
                    sb.AppendLine($"{coinsCount} coin(s) with value {currentCoin}");
                }
            }

            Console.WriteLine($"Number of coins to take: {counter}");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
