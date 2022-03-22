using System;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "end")
            {
                string reversedWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    char currChar = word[i];
                    reversedWord += currChar;
                }
                Console.WriteLine($"{word} = {reversedWord}");
                
            }
        }
    }
}
