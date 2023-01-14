using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackSize = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(numbers);

            int currRackZize = rackSize;
            int numbersOfRacks = 1;

            while (clothes.Count != 0)
            {
                currRackZize -= clothes.Peek();
                if (currRackZize < 0)
                {
                    currRackZize = rackSize;
                    numbersOfRacks++;

                    continue;
                }

                clothes.Pop();
            }

            Console.WriteLine(numbersOfRacks);
        }
    }
}
