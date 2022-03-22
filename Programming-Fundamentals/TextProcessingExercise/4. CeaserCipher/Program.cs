using System;
using System.Text;

namespace _4._CeaserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append((char)(c + 3));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
