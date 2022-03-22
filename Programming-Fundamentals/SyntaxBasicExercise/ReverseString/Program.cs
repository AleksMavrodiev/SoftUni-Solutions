using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                Console.Write(c);
            }
        }
    }
}
