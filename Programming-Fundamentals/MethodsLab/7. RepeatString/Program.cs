using System;
using System.Text;

namespace _7._RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatWord(input, count));
        }
        static string RepeatWord(string word, int times)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
