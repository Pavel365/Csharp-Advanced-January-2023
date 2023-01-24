using System;
using System.Linq;

namespace P._03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filterByUpperCase = a=> a[0] == char.ToUpper(a[0]);

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => filterByUpperCase(s))
                .ToArray();

            foreach (string item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
