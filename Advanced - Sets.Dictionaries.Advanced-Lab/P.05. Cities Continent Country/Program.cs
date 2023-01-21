using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Cities_Continent_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                string continent = splitted[0];
                string country = splitted[1];
                string city = splitted[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach (var comtinent in continents)
            {
                Console.WriteLine($"{comtinent.Key}:");

                foreach (var country in comtinent.Value)
                {
                    Console.WriteLine($"   {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
