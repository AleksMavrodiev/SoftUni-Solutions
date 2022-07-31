using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int exceptionCount = 0;
            while (exceptionCount < 3)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string action = input[0];
                    if (action == "Replace")
                    {
                        int index = int.Parse(input[1]);
                        int element = int.Parse(input[2]);
                        Replace(numbers, index, element);
                    }
                    else if (action == "Print")
                    {
                        int startIndex = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        Print(numbers, startIndex, endIndex);
                    }
                    else if (action == "Show")
                    {
                        int index = int.Parse(input[1]);
                        Show(numbers, index);
                    }

                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    exceptionCount++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

        static bool ValidateIndex(List<int> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                throw new ArgumentException("The index does not exist!");
            }
            return true;
        }

        static void Replace(List<int> numbers, int index, int element)
        {
            if (ValidateIndex(numbers, index))
            {
                numbers[index] = element;
            }
        }

        static void Print(List<int> numbers, int startIndex, int endIndex)
        {
            if (ValidateIndex(numbers ,startIndex) && ValidateIndex(numbers ,endIndex))
            {
                List<int> resizedList = new List<int>();
                for (int i = startIndex; i <= endIndex; i++)
                {
                    resizedList.Add(numbers[i]);
                }
                Console.WriteLine(String.Join(", ", resizedList));
            }
        }

        static void Show(List<int> numbers, int index)
        {
            if (ValidateIndex(numbers, index))
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
