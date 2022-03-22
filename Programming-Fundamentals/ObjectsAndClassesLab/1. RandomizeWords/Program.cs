using System;

namespace _1._RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, words.Length);
                string oldValue = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = oldValue;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
