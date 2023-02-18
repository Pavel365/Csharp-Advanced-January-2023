using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToHashSet();

            Func<HashSet<int>, int> min = numbers =>
            {
                int minNum = int.MaxValue;
                foreach (var num in numbers)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }

                return minNum;
            };

            Console.WriteLine(min(numbers));
        }
    }
}
