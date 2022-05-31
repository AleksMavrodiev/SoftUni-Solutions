using System;
using System.Collections.Generic;

namespace _5._CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            SortedDictionary<char, int> occCharacter = new SortedDictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (!occCharacter.ContainsKey(word[i]))
                {
                    occCharacter.Add(word[i], 1);
                }
                else
                {
                    occCharacter[word[i]]++;
                }
            }
            foreach (var ch in occCharacter)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
