using System;
using System.Collections.Generic;
using System.Linq;

namespace P._06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothesByColor = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = tokens[0];

                if (!clothesByColor.ContainsKey(color))
                {
                    clothesByColor.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentClothing = tokens[j];

                    if (!clothesByColor[color].ContainsKey(currentClothing))
                    {
                        clothesByColor[color].Add(currentClothing, 0);
                    }

                    clothesByColor[color][currentClothing]++;
                }
            }

            string[] findTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var cothByColor in clothesByColor)
            {
                Console.WriteLine($"{cothByColor.Key} clothes:");

                foreach (var coth in cothByColor.Value)
                {
                    string printItem = $"* {coth.Key} - {coth.Value}";

                    if (cothByColor.Key == findTokens[0] && coth.Key == findTokens[1])
                    {
                        printItem += " (found!)";
                    }
                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
