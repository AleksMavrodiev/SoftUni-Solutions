using System;
using System.Linq;

namespace _3._COuntUppecaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isFirstLetterCapital = x => x.Length > 0 && char.IsUpper(x[0]);
            Console.WriteLine(string.Join("\r\n", Console.ReadLine().Split(" ").Where(isFirstLetterCapital)));
        }
    }
}
