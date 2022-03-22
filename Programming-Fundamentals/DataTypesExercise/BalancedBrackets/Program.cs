using System;

namespace BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leftBracketCount = 0;
            int rightBracketCount = 0;
            int n = int.Parse(Console.ReadLine());
            char currCh;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool isChar = char.TryParse(input, out currCh);
                if (isChar && currCh == 40)
                {
                    leftBracketCount++;
                }
                else if (isChar && currCh == 41)
                {
                    rightBracketCount++;
                }
            }
            if (leftBracketCount == rightBracketCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
