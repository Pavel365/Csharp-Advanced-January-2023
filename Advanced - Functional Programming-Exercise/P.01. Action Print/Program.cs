using System;
using System.Linq;

namespace P._01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[]> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            print(names);
        }
    }
}
