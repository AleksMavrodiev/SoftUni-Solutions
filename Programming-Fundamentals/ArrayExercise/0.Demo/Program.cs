using System;
using System.Linq;

namespace _0.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
