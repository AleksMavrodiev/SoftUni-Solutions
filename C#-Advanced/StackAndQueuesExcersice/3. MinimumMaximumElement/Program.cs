using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MinimumMaximumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.StartsWith('1'))
                {
                    int element = int.Parse(input.Substring(2));
                    stack.Push(element);
                }
                else if (input.StartsWith('2'))
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (input.StartsWith('3'))
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (input.StartsWith('4'))
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
