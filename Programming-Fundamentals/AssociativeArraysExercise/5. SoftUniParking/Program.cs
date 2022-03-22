using System;
using System.Collections.Generic;

namespace _5._SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> userPlates = new Dictionary<string, string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string command = cmdArgs[0];
                string user = cmdArgs[1];
                if (command == "register")
                {
                    string plate = cmdArgs[2];
                    Register(userPlates, user, plate);
                }
                else if (command == "unregister")
                {
                    Deregister(userPlates, user);
                }
            }
            foreach (var item in userPlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
        static void Register(Dictionary<string, string> userPlates, string user, string plate)
        {
            if (userPlates.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: already registered with plate number {plate}");
            }
            else
            {
                userPlates[user] = plate;
                Console.WriteLine($"{user} registered {plate} successfully");
            }
        }

        static void Deregister(Dictionary<string, string> userPlates, string user)
        {
            if (userPlates.ContainsKey(user))
            {
                userPlates.Remove(user);
                Console.WriteLine($"{user} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
        }
    }
}
