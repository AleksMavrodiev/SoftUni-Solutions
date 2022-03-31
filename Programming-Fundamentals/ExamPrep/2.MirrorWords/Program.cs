using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@|#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string[]> pairs = new List<string[]>();
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = string.Join("", match.Groups["secondWord"].Value.Reverse());
                if (firstWord == secondWord)
                {
                    pairs.Add(new string[] {firstWord, secondWord});
                }
            }
            if (matches.Any())
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (pairs.Any())
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(string.Join(", ", pairs.Select(x => $"{x[0]} <=> {x[1]}")));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
