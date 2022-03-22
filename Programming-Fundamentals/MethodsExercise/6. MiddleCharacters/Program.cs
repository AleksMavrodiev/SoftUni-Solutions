using System;

namespace _6._MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            ReturnMiddleCharacter(word);
        }

        static void ReturnMiddleCharacter(string word)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{word[word.Length / 2 - 1]}{word[word.Length / 2]}");
            }
        }
    }
}
