using System;
using System.Collections.Generic;
using System.Linq;

namespace P._02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstset =  new HashSet<int>();
            HashSet<int> secondset = new HashSet<int>();

            int[] counts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < counts[0]; i++)
            {
                firstset.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < counts[1]; i++)
            {
                secondset.Add(int.Parse(Console.ReadLine()));
            }

            firstset.IntersectWith(secondset);

            Console.WriteLine(String.Join(" ", firstset));
        }
    }
}
