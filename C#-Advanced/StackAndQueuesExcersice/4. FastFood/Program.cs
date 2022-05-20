using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCapacity = int.Parse(Console.ReadLine());
            int[] food = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(food);
            int n = orders.Count;
            Console.WriteLine(orders.Max());
            for (int i = 0; i < n; i++)
            {
                if (orders.Peek() <= orderCapacity)
                {
                    orderCapacity -= orders.Dequeue();
                }
            }
            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
