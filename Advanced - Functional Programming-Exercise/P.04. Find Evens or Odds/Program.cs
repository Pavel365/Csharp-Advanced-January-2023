using System;
using System.Collections.Generic;
using System.Linq;

namespace P._04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(b => int.Parse(b))
                .ToArray();

            string command = Console.ReadLine();

            Func<int, int, List<int>> generateRange = (start, end) =>
            {
                List<int> range = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    range.Add(i);
                }

                return range;
            };

            List<int> numbers = generateRange(bounds[0], bounds[1]);

            Predicate<int> match;

            if (command == "even")
            {
                match = number => number % 2 == 0;
            }
            else
            {
                match = number => number % 2 != 0;
            }

            foreach (int number in numbers)
            {

                if (match(number))
                {
                    Console.Write($"{number} ");
                }
            }
        } 
    }
}
