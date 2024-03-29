﻿using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> queue = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    int n = queue.Count;
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
