using System;

namespace _8._LettersChangenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in input)
            {
                sum += CalculateWordSum(word);
            }
            Console.WriteLine($"{sum:F2}");
        }

        static decimal CalculateWordSum(string word)
        {
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int number = int.Parse(word.Substring(1, word.Length - 2));
            int firstLetterPosition = GetAlphabeticalPosition(firstLetter);
            int lastLetterPosition = GetAlphabeticalPosition(lastLetter);
            decimal sum = 0;
            if (firstLetter >= 65 && firstLetter <= 90)
            {
                sum += (decimal)number / firstLetterPosition;
            }
            else
            {
                sum += (decimal)number * firstLetterPosition;
            }
            if (lastLetter >= 65 && lastLetter <=90)
            {
                sum -= lastLetterPosition;
            }
            else
            {
                sum += lastLetterPosition;
            }
            return sum;
        }
        static int GetAlphabeticalPosition(char ch)
        {
            ch = char.ToLower(ch);
            return ch - 96;
        }
    }
}
