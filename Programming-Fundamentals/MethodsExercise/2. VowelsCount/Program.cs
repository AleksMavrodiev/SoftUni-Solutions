using System;
using System.Linq;

namespace _2._VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetVowelsCount(word.ToLower());

        }
        static void GetVowelsCount(string word)
        {
            int vowelsCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
