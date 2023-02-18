using System;
using System.Collections.Generic;
using System.Linq;

namespace P._08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            HashSet<int> deviders = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(s => int.Parse(s))
               .ToHashSet();

            int[] numbers = Enumerable.Range(1, endOfRange).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int devider in deviders)
            {
                predicates.Add(n => n % devider == 0);
            }

            foreach (int number in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
