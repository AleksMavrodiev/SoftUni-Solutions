using System;
using System.Collections.Generic;

namespace _1._CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char currentChar = word[i];
                    if (occurances.ContainsKey(currentChar))
                    {
                        occurances[currentChar]++;
                    }
                    else
                    {
                        occurances.Add(currentChar, 1);
                    }
                }
            }
            foreach (var charavter in occurances)
            {
                Console.WriteLine($"{charavter.Key} -> {charavter.Value}");
            }
        }
    }
}
