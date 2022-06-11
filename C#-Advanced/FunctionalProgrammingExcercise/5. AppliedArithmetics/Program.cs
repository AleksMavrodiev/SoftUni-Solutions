using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, List<int>> operation = null;
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    operation = x => x.Select(x => x + 1).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "multiply")
                {
                    operation = x => x.Select(x => x * 2).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "subtract")
                {
                    operation = x => x.Select(x => x - 1).ToList();
                    numbers = operation(numbers);
                }
                else if (command == "print")
                {
                    print(numbers); 
                }
            }
        }
    }
}
