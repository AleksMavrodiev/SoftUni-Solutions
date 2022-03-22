using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s|\-])2\1(\d{3})\1(\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
