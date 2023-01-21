using System;
using System.Collections.Generic;
using System.Linq;

namespace P._01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> occurences = new Dictionary<double, int>();

            foreach (double num in input)
            {
                if (occurences.ContainsKey(num))
                {
                    occurences[num]++;
                }
                else
                {
                    occurences[num] = 1;
                }
            }

            foreach (var num in occurences)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
