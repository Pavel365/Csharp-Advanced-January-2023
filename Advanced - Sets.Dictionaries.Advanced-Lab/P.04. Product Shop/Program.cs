using System;
using System.Collections.Generic;
using System.Linq;

namespace P._04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , Dictionary<string, double>> shops =
                new Dictionary<string , Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] splitted = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string shop = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop][product] = price;
            }
            shops = shops.OrderBy(s => s.Key)
                .ToDictionary(s => s.Key, s => s.Value);    

            foreach ( var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
