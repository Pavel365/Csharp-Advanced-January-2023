using System;
using System.Collections.Generic;
using System.Linq;

namespace P._04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersCounts = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersCounts.ContainsKey(number))
                {
                    numbersCounts.Add(number, 0);
                }

                numbersCounts[number]++;
            }

            Console.WriteLine(numbersCounts.Single(n => n.Value % 2 == 0).Key);

        }
    }
}
