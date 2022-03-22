using System;
using System.Linq;

namespace _9._PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                CheckPalindrome(command);
            }
        }
        static void CheckPalindrome(string number)
        {
            int counter = 0;
            int[] firstArray = new int[number.Length];
            int[] secondArray = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                firstArray[i] = number[i];
            }

            for (int j = number.Length - 1; j >= 0; j--)
            {
                secondArray[counter] = number[j];
                counter++;
            }
            if (firstArray.SequenceEqual(secondArray))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
