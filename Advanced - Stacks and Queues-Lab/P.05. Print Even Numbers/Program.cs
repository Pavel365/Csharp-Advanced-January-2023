using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> allnumbers = new Queue<int>(numbers);

            while (allnumbers.Count != 1)
            {
                int currNum = allnumbers.Dequeue();

                if (currNum % 2 == 0)
                {
                    Console.Write(currNum + ", ");
                }
            }

            int lastNum = allnumbers.Dequeue();

            if (lastNum % 2 == 0)
            {
                Console.WriteLine(lastNum);
            }
        }
    }
}
