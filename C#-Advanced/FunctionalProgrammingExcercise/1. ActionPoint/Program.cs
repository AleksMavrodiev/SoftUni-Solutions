using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Action<string> print = name => Console.WriteLine(name);
            names.ForEach(print);
        }
    }
}
