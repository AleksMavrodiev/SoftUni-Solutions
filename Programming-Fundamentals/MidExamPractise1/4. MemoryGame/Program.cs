using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            int movesCount = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int firstIndex = int.Parse(cmdArgs[0]);
                int secondIndex = int.Parse(cmdArgs[1]);
                movesCount++;
                if (CheckIndex(numbers, firstIndex) && CheckIndex(numbers, secondIndex) && CheckEquals(firstIndex, secondIndex))
                {
                    if (numbers[firstIndex] == numbers[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");
                        string guessedElement = numbers[firstIndex];
                        numbers.Remove(guessedElement);
                        numbers.Remove(guessedElement);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    numbers.Insert(numbers.Count / 2, $"-{movesCount}a");
                    numbers.Insert(numbers.Count / 2, $"-{movesCount}a");
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    return;
                }
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static bool CheckIndex(List<string> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }

        static bool CheckEquals(int first, int second)
        {
            return first != second;
        }
    }
}
