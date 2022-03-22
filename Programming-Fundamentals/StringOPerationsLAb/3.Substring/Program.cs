using System;

namespace _3.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string removeString = Console.ReadLine();
            string word = Console.ReadLine();
            while (word.Contains(removeString))
            {
                int index = word.IndexOf(removeString);
                word = word.Remove(index, removeString.Length);
            }
            Console.WriteLine(word);
        }
    }
}
