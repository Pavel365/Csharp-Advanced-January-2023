using System;
using System.Collections.Generic;
using System.Linq;

namespace P._10._ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();


            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Add filter")
                {
                    filters.Add(filter + value, GetPredicate(filter, value));
                }
                else if (action == "Remove filter")
                {
                    filters.Remove(filter + value);
                }
            }
            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));
            
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return s => s.StartsWith(value);
                case "Ends with":
                    return s => s.EndsWith(value);
                case "Contains":
                    return s => s.Contains(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                default:
                    return null;
            }
        }
    }
}
