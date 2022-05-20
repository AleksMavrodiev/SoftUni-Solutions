﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(input2[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                if (numbers.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
