using System;

namespace _3._CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            PrintCharacters(firstSymbol, secondSymbol);
        }

        static void PrintCharacters(char start, char end)
        {
            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            
        }
    }
}
