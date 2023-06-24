using System;
using System.Collections.Generic;

namespace PermutationsWithoutRepetitions
{
    internal class Program
    {
        private static string[] elements;
        private static string[] combinations;
        private static bool[] used;
        static void Main(string[] args)
        {
            //elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //int k = int.Parse(Console.ReadLine());
            //combinations = new string[k];
            //used = new bool[elements.Length];
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());


            Console.WriteLine(Binom(n, k));
        }

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Permute(index + 1);
                var swapped = new HashSet<string> { elements[index] };
                for (int i = index + 1; i < elements.Length; i++)
                {
                    if (!swapped.Contains(elements[i]))
                    {
                        Swap(index, i);
                        Permute(index + 1);
                        Swap(index, i);
                        swapped.Add(elements[i]);
                    }
                }
            }
        }

        private static void Swap(int first, int second)
        {
            (elements[first], elements[second]) = (elements[second], elements[first]);
        }

        private static void Variations(int index)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        combinations[index] = elements[i];
                        Variations(index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        private static void VariationsWithRepetitions(int index)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    combinations[index] = elements[i];
                    VariationsWithRepetitions(index + 1);
                }
            }
        }

        private static void Combinations(int index, int start)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
            }
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                    combinations[index] = elements[i];
                    Combinations(index + 1, i + 1);
                }
            }
        }

        private static void CombinationsWithRepetition(int index, int start)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
            }
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                    combinations[index] = elements[i];
                    CombinationsWithRepetition(index + 1, i);
                }
            }
        }

        private static long Binom(int n, int k)
        {
            if (n <= 1)
            {
                return 1;
            }
            if (k == 0 || k == n)
            {
                return 1;
            }
            return Binom(n - 1, k) + Binom(n - 1, k - 1);
        }

    }
}
