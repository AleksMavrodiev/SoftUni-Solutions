using System;
using System.Text;

namespace _7._StringExplotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder newWord = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    newWord.Append(input[i]);
                    int currBombPower = int.Parse(input[i + 1].ToString());
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                        continue;
                    }
                    else
                    {
                        newWord.Append(input[i]);
                    }
                }
            }
            Console.WriteLine(newWord.ToString());
        }
    }
}
