using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsPositions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (bugsPositions.Contains(i))
                {
                    field[i] = 1;
                }
            }
            
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int startIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);
                if (startIndex < 0 || startIndex >= field.Length)
                {
                    continue;
                }
                if (field[startIndex] == 0)
                {
                    continue;
                }

                field[startIndex] = 0;
                int nextIndex = startIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
                    
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
