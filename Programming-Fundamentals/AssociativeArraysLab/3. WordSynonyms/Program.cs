using System;
using System.Collections.Generic;

namespace _3._WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairCOunt = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> textBook = new Dictionary<string, List<string>>();
            for (int i = 0; i < pairCOunt; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!textBook.ContainsKey(word))
                {
                    textBook.Add(word, new List<string>());
                }
                textBook[word].Add(synonym);
            }
            foreach (var item in textBook)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
