using System;
using System.Collections.Generic;
using System.Linq;

namespace P._04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(numbers);

            Console.WriteLine(orders.Max());

            while (orders.Count != 0)
            {
                quantity -= orders.Peek();

                if (quantity < 0)
                {
                    break;
                }

                orders.Dequeue();
            }

            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
