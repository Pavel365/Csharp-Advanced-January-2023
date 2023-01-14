using System;
using System.Collections.Generic;
using System.Linq;

namespace P._12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cups = Console.ReadLine().Split().Select(int.Parse).Reverse();
            var bottles = Console.ReadLine().Split().Select(int.Parse);

            Stack<int> cupsStack = new Stack<int>(cups);
            Stack<int> bottlesStack = new Stack<int>(bottles);
            int wastedLiters = 0;

            while (cupsStack.Count != 0 && bottlesStack.Count != 0)
            {
                int bottleSize = bottlesStack.Pop();
                int cupSize = cupsStack.Pop();


                if (cupSize > bottleSize)
                {
                    int fillUp = cupSize - bottleSize;
                    cupsStack.Push(fillUp);
                }
                else
                {
                    wastedLiters += bottleSize - cupSize;
                }
            }

            if (bottlesStack.Count != 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
            else
            {

                Console.WriteLine($"Cups: {string.Join(" ", cupsStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
        }
    }
}
