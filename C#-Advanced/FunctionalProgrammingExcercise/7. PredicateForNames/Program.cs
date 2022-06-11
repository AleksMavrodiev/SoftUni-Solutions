using System;

namespace _7._PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Predicate<string> lengthCheck = x => x.Length == n;
            string[] words = Console.ReadLine().Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (lengthCheck(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
