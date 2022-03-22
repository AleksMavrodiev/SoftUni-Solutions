using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    int numberToAdd = int.Parse(action[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action[0] == "Insert")
                {
                    int numberToAdd = int.Parse(action[1]);
                    int indexToAdd = int.Parse(action[2]);
                    if (CheckIndex(numbers, indexToAdd))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(indexToAdd, numberToAdd);
                }
                else if (action[0] == "Remove")
                {
                    int indexToRemove = int.Parse(action[1]);
                    if (CheckIndex(numbers, indexToRemove))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(indexToRemove);
                }
                else if (action[0] == "Shift")
                {
                    int count = int.Parse(action[2]);
                    if (action[1] == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }

        static bool CheckIndex(List<int> numbers, int index)
        {
            return index < 0 || index >= numbers.Count;
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;
            for (int i = 0; i < realCount; i++)
            {
                int oldValue = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(oldValue);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;
            for (int i = 0; i < realCount; i++)
            {
                int oldValue = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, oldValue);
            }
        }
    }
}
