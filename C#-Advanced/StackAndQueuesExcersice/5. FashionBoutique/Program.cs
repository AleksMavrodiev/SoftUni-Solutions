using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clotheValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(clotheValues);
            int rackCapacity = int.Parse(Console.ReadLine());
            int n = clothes.Count;
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (clothes.Peek() + sum <= rackCapacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    sum = 0;
                    sum += clothes.Pop();
                    counter++;
                }
            }
            counter++;
            Console.WriteLine(counter);
        }
    }
}
