using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Trifunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> check = (name, threshhold) => name.Select(ch => (int)ch).Sum() >= threshhold;
            
            foreach (var name in names)
            {
                if (check(name, n))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            
        }
    }
}
