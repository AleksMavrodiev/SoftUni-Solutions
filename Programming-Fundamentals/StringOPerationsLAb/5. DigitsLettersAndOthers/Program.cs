using System;
using System.Text;

namespace _5._DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (char.IsLetter(currChar))
                {
                    letters.Append(currChar);
                }
                else if (char.IsDigit(currChar))
                {
                    numbers.Append(currChar);
                }
                else
                {
                    characters.Append(currChar);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
