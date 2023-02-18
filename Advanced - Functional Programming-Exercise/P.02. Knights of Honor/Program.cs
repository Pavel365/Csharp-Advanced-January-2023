using System;
using System.Linq;

namespace P._02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[], string> print = (names, title) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };

            print(names, "Sir");
        }
    }
}
