using System;
using System.Linq;

namespace _6.ModifiedJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rowCount][];
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split();
                string action = cmdArgs[0];
                int rowIndex = int.Parse(cmdArgs[1]);
                int colIndex = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                if (rowIndex >= 0 && rowIndex < jaggedArray.Length && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
            }
            for (int row = 0; row < rowCount; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }
    }
}
