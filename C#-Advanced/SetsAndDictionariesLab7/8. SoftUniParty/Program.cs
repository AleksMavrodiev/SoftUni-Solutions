using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string adding = string.Empty;
            while ((adding = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(adding[0]))
                {
                    vip.Add(adding);
                }
                else
                {
                    guests.Add(adding);
                }
            }
            string coming = string.Empty;
            while ((coming = Console.ReadLine()) != "END")
            {
                if (vip.Contains(coming))
                {
                    vip.Remove(coming);
                }
                else
                {
                    guests.Remove(coming);
                }
            }
            Console.WriteLine(guests.Count + vip.Count);
            if (vip.Count > 0)
            {
                foreach (var guest in vip)
                {
                    Console.WriteLine(guest);
                }
            }
            if (guests.Count > 0)
            {
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
