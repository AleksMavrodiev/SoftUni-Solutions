using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                if (action == "add")
                {
                    int firstNumber = int.Parse(cmdArgs[1]);
                    int secondNumber = int.Parse(cmdArgs[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (action == "remove")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
