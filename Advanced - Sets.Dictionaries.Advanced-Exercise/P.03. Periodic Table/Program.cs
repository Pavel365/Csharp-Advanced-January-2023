using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<string> periodicElements = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] elsements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                periodicElements.UnionWith(elsements);
            }
            Console.WriteLine(string.Join(" ", periodicElements));
        }
    }
}
