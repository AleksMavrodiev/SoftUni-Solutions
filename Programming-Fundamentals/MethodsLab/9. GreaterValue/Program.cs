using System;

namespace _9._GreaterValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNum, secondNum));
            }
            else if (command == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else if (command == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();
                Console.WriteLine(GetMax(firstWord, secondWord));
            }
        }
        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMax(string firstWord, string seondWord)
        {
            if(firstWord.CompareTo(seondWord) < 0)
            {
                return seondWord;
            }
            else
            {
                return firstWord;
            }
        }
    }
}
