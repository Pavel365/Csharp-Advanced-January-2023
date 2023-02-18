using System;
using System.Linq;

namespace P._07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[], Predicate<string>> printNames = (names, match) =>
            {
                foreach (string name in names)
                {
                    if (match(name))
                    {
                        Console.WriteLine(name);
                    }
                    
                }
            };

            Predicate<string> match = name =>
            {
               return name.Length <= length;
            };

            printNames(names, match);
        }
    }
}
