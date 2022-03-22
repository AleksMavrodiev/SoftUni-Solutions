using System;

namespace DecryptingMessege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char currIndex = char.Parse(Console.ReadLine());
                int newChar = currIndex + key;
                word += (char)newChar;
            }
            Console.WriteLine(word);
        }
    }
}
