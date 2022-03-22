using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombs[0];
            int bombPower = bombs[1];
            while (numbers.Contains(bombNumber))
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                DetonateBomb(numbers, indexOfBomb, bombPower);
            }
            Console.WriteLine(numbers.Sum());
        }

        static void RemoveRight(List<int> numbers, int indexOfBomb, int bombpower)
        {
            int count = indexOfBomb + bombpower;
            if (count >= numbers.Count)
            {
                count = numbers.Count - 1;
            }
            for (int i = indexOfBomb; i <= count; i++)
            {
                numbers.RemoveAt(indexOfBomb);
            }
        }

        static void RemoveLeft(List<int> numbers, int indexOfBomb, int bombpower)
        {
            int count = indexOfBomb - bombpower;
            if (count < 0)
            {
                count = 0;
            }
            for (int i = indexOfBomb - 1; i >= count; i--)
            {
                numbers.RemoveAt(i);
            }
        }

        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombpower)
        {
            RemoveRight(numbers, indexOfBomb, bombpower);
            RemoveLeft(numbers, indexOfBomb, bombpower);
        }
    }
}
