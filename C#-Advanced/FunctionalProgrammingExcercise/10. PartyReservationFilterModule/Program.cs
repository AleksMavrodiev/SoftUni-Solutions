using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._PartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] cmdArgs = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string addRemove = cmdArgs[0];
                string commandType = cmdArgs[1];
                string argument = cmdArgs[2];
                if (addRemove == "Add filter")
                {
                    Predicate<string> currPredicate = GetPredicate(commandType, argument);
                    filters[argument] = currPredicate;

                }
                else if (addRemove == "Remove filter")
                {
                    Predicate<string> currPredicate = GetPredicate(commandType, argument);
                    filters.Remove(argument);
                }
            }

            foreach (var filter in filters)
            {
                guests.RemoveAll(filter.Value);
            }
            Console.WriteLine(String.Join(" ", guests));
        }

        private static Predicate<string> GetPredicate(string commandType, string argument)
        {
            switch (commandType)
            {
                case "Starts with":
                    return (name) => name.StartsWith(argument);
                    break;
                case "Ends with":
                    return (name) => name.EndsWith(argument);
                    break;
                case "Length":
                    return (name) => name.Length == int.Parse(argument);
                    break;
                case "Contains":
                    return (name) => name.Contains(argument);
                    break;
                default:
                    throw new ArgumentException($"Invalid command type: " + commandType);
                    break;
            }
        }
    }
}
