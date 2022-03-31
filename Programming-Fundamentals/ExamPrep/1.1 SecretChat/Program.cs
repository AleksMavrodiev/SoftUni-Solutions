using System;
using System.Linq;

namespace _1._1_SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedWord = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string operation = cmdArgs[0];
                if (operation == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    concealedWord = concealedWord.Insert(index, " ");
                }
                else if (operation == "Reverse")
                {
                    string substring = cmdArgs[1];
                    if (concealedWord.Contains(substring))
                    {
                        int startIndex = concealedWord.IndexOf(substring);
                        concealedWord = concealedWord.Remove(startIndex, substring.Length);
                        concealedWord = concealedWord + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (operation == "ChangeAll")
                {
                    string stringToBeReplaced = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    concealedWord = concealedWord.Replace(stringToBeReplaced, replacement);
                }
                Console.WriteLine(concealedWord);
            }
            Console.WriteLine($"You have a new text message: {concealedWord}");
        }
    }
}
