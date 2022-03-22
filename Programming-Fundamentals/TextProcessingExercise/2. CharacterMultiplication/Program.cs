using System;

namespace _2._CharacterMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string firstWord = words[0];
            string secondWord = words[1];
            string rest = BiggerString(firstWord, secondWord);
            int sum = 0;
            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                sum += firstWord[i] * secondWord[i]; 
            }
            if (rest == "first")
            {
                for (int i = secondWord.Length ; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }
            else if(rest == "second")
            {
                for (int i = firstWord.Length ; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }
            Console.WriteLine(sum);
        }
        static string BiggerString(string firstWord, string secondWord)
        {
            if (firstWord.Length >= secondWord.Length)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }
    }
}
