using System;
using System.Collections.Generic;
using System.Linq;

namespace Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> coffee = new Dictionary<int, string>()
            {
                { 50 ,"Cortado"},
                { 75, "Espresso"},
                { 100, "Capuccino"},
                { 150, "Americano"},
                { 200, "Latte"}
            };

            Queue<int> quantiiesOfCoffee = new Queue<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray()
                );

            Stack<int> quantiiesOfMilk = new Stack<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray()
                );

            Dictionary<string, int> drinks = new Dictionary<string, int>()
            {
                {"Cortado", 0 },
                {"Espresso", 0 },
                {"Capuccino", 0 },
                {"Americano", 0},
                {"Latte", 0 }
            };

            while (quantiiesOfCoffee.Count > 0 && quantiiesOfMilk.Count > 0)
            {
                int currCoffee = quantiiesOfCoffee.Dequeue();
                int currMilk = quantiiesOfMilk.Pop();

                if (coffee.ContainsKey(currCoffee + currMilk))
                {
                    drinks[coffee[currCoffee + currMilk]]++;
                }
                else
                {
                    quantiiesOfMilk.Push(currMilk - 5);
                }
            }

            if (quantiiesOfCoffee.Any() || quantiiesOfMilk.Any())
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }

            if (!quantiiesOfCoffee.Any())
            {
                Console.WriteLine("Coffee left: none");
            }
            else if (quantiiesOfCoffee.Any())
            {
                Console.WriteLine($"Coffee left: {string.Join(", ", quantiiesOfCoffee)}");
            }

            if (!quantiiesOfMilk.Any())
            {
                Console.WriteLine("Milk left: none");
            }
            else if (quantiiesOfMilk.Any())
            {
                Console.WriteLine($"Milk left: {string.Join(", ", quantiiesOfMilk)}");
            }

            foreach (var kvp in drinks.Where(c => c.Value > 0)
                .OrderBy(c => c.Value)
                .ThenByDescending(c => c.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

}
