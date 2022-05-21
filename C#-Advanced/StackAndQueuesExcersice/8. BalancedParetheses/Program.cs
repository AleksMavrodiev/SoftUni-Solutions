using System;
using System.Collections.Generic;

namespace _8._BalancedParetheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openBrackets = new Stack<char>();
            bool isBalanced = true;
            foreach (char bracket in input)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    openBrackets.Push(bracket);
                }
                else if (bracket == ')' || bracket == ']' || bracket == '}')
                {
                    if (openBrackets.Count <= 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    char lastBracket = openBrackets.Pop();
                    if (lastBracket == '(' && bracket == ')')
                    {
                        continue;
                    }
                    else if (lastBracket == '[' && bracket == ']')
                    {
                        continue;
                    }
                    else if (lastBracket == '{' && bracket == '}')
                    {
                        continue;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
