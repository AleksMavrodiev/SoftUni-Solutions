using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._KnightsHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Action<string> knightsTitle = name => Console.WriteLine("Sir " + name);
            names.ForEach(knightsTitle);
        }
    }
}
