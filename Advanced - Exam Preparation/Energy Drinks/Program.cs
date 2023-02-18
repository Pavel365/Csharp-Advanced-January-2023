using System;
using System.Collections.Generic;
using System.Linq;

namespace Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> miligrams = new Stack<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> driks = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int tottalCaffein = 0;

            while (miligrams.Count > 0 && driks.Count > 0)
            {
                int lastCaffein = miligrams.Pop();
                int firstDrink = driks.Dequeue();

                int multiplication = lastCaffein * firstDrink;

                if (tottalCaffein + multiplication <= 300)
                {
                    tottalCaffein += multiplication;
                }
                else
                {
                    driks.Enqueue(firstDrink);
                    tottalCaffein -= 30;

                    if (tottalCaffein < 0)
                    {
                        tottalCaffein = 0;
                    }
                }
            }

            if (driks.Count > 0)
            {
                Console.WriteLine($"Drinks left: { string.Join(", ", driks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {tottalCaffein} mg caffeine.");
        }
    }
}
