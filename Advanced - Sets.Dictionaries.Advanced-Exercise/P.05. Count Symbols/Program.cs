using System;
using System.Collections.Generic;

namespace P._05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            foreach (char symbol in input)
            {
                if (!charsCount.ContainsKey(symbol))
                {
                    charsCount.Add(symbol, 0);
                }

                charsCount[symbol]++;
            }

            foreach (var charCounts in charsCount)
            {
                Console.WriteLine($"{charCounts.Key}: {charCounts.Value} time/s");
            }
        }
    }
}
