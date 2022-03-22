using System;
using System.Linq;

namespace _11._ArrayManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();
                if (action[0] == "exchange")
                {
                    int index = int.Parse(action[1]);
                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    input = Exchange(input, index);
                }
                else if (action[0] == "max")
                {
                    string type = action[1];
                    int index = MaxElementOfType(input, type);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (action[0] == "min")
                {
                    string type = action[1];
                    int index = MinElementOfType(input, type);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (action[0] == "first")
                {
                    int count = int.Parse(action[1]);
                    if (count < 0 || count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string type = action[2];
                    FirstElementsOfType(input, count, type);
                }
                else if (action[0] == "last")
                {
                    int count = int.Parse(action[1]);
                    if (count < 0 || count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string type = action[2];
                    LastElementsType(input, count, type);
                }
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        static int[] Exchange(int[] numbers, int index)
        {
            int[] changedArray = new int[numbers.Length];
            int counter = 0;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                changedArray[counter] = numbers[i];
                counter++;
            }
            for (int j = 0; j <= index; j++)
            {
                changedArray[counter] = numbers[j];
                counter++;
            }
            return changedArray;
        }

        static int MaxElementOfType(int[] number, string type)
        {
            int maxNumber = int.MinValue;
            int index = -1;
            for (int i = 0; i < number.Length; i++)
            {
                if (type == "even")
                {
                    if (number[i] % 2 == 0 && number[i] >= maxNumber)
                    {
                        maxNumber = number[i];
                        index = i;
                    }
                }
                else if (type == "odd")
                {
                    if (number[i] % 2 != 0 && number[i] >= maxNumber)
                    {
                        maxNumber = number[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinElementOfType(int[] numbers, string type)
        {

            {
                int minNumber = int.MaxValue;
                int index = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (type == "even")
                    {
                        if (numbers[i] % 2 == 0 && numbers[i] <= minNumber)
                        {
                            minNumber = numbers[i];
                            index = i;
                        }
                    }
                    else if (type == "odd")
                    {
                        if (numbers[i] % 2 != 0 && numbers[i] <= minNumber)
                        {
                            minNumber = numbers[i];
                            index = i;
                        }
                    }
                }
                return index;
            }
        }

        static void FirstElementsOfType(int[] numbers, int count, string type)
        {
            int[] arrOfType = new int[count];
            int counter = 0;
            int elementsFound = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (type == "even")
                {
                    if (numbers[i] % 2 == 0)
                    {
                        arrOfType[counter] = numbers[i];
                        elementsFound++;
                        counter++;
                        if (counter >= arrOfType.Length)
                        {
                            break;
                        }
                    }
                }
                else if (type == "odd")
                {
                    if (numbers[i] % 2 != 0)
                    {
                        arrOfType[counter] = numbers[i];
                        elementsFound++;
                        counter++;
                        if (counter >= arrOfType.Length)
                        {
                            break;
                        }
                    }
                }
            }
            if (elementsFound > 0)
            {
                Console.Write("[");
                for (int i = 0; i < elementsFound; i++)
                {
                    if (i == elementsFound - 1)
                    {
                        Console.Write($"{arrOfType[i]}");
                    }
                    else
                    {
                        Console.Write($"{arrOfType[i]}, ");
                    }
                }
                Console.WriteLine("]");
            }
            else if (elementsFound == 0)
            {
                Console.WriteLine("[]");
            }
        }

        static void LastElementsType(int[] numbers, int count, string type)
        {
            int[] arrOfType = new int[count];
            int counter = 0;
            int elementsFound = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (type == "even")
                {
                    if (numbers[i] % 2 == 0)
                    {
                        arrOfType[counter] = numbers[i];
                        elementsFound++;
                        counter++;
                        if (counter >= arrOfType.Length)
                        {
                            break;
                        }
                    }
                }
                else if (type == "odd")
                {
                    if (numbers[i] % 2 != 0)
                    {
                        arrOfType[counter] = numbers[i];
                        elementsFound++;
                        counter++;
                        if (counter >= arrOfType.Length)
                        {
                            break;
                        }
                    }
                }
            }
            Array.Resize(ref arrOfType, elementsFound);
            Array.Reverse(arrOfType);
            if (elementsFound > 0)
            {
                Console.Write("[");
                for (int i = 0; i < elementsFound; i++)
                {
                    if (i == elementsFound - 1)
                    {
                        Console.Write($"{arrOfType[i]}");
                    }
                    else
                    {
                        Console.Write($"{arrOfType[i]}, ");
                    }
                }
                Console.WriteLine("]");
            }
            else if (elementsFound == 0)
            {
                Console.WriteLine("[]");
            }
        }
    }
}