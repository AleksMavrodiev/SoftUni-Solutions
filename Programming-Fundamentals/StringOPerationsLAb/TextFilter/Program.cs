using System;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
           foreach (string word in bannedWords)
           {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new String('*', word.Length));
                }
           }
            Console.WriteLine(text);
        }
    }
}
