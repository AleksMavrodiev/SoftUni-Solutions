using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (operand == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if (operand == "-")
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
