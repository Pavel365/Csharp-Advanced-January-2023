using System;
using System.Collections.Generic;
using System.Linq;

namespace P._06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int devider = int.Parse(Console.ReadLine());

            Func<List<int>, Predicate<int>, List<int>> excludeDevisible = (numbers, match) =>
            {
                List<int> result = new List<int>();
                foreach (int num in numbers)
                {
                    if (!match(num))
                    {
                        result.Add(num);
                    }
                }

                return result;
            };



            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }

                return result;
            };
            
            numbers = excludeDevisible(numbers, n => n % devider == 0);
            numbers = reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
