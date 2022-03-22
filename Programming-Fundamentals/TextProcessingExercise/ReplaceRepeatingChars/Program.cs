using System;
using System.Linq;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                bool isEqual = false;
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        isEqual = true;
                        text = text.Remove(j, 1);
                        j--;
                    }
                    else
                    {
                        isEqual = false;
                    }
                    if (!isEqual)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
