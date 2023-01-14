using System;
using System.Collections.Generic;
using System.Linq;

namespace P._11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                );
            Queue<int> locks = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                );
            int intelligence = int.Parse(Console.ReadLine());

            int initialBulletsCount = bullets.Count;

            int currBarrelSize = barrelSize;

            for (int i = 0; i < initialBulletsCount; i++)
            {
                if (bullets.Pop() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                currBarrelSize--;

                if (currBarrelSize == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    currBarrelSize = barrelSize;
                }

                if (!bullets.Any() && locks.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }

                if (!locks.Any())
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (initialBulletsCount - bullets.Count) * bulletPrice}");
                    return;
                }
            }
        }
    }
}
