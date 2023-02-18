using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] drinkTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] numbersTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            CustomTuple<string, string> nameAdress = 
                new CustomTuple<string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2]);

            CustomTuple<string, int> nameBeer =
                new CustomTuple<string, int>(drinkTokens[0], int.Parse(drinkTokens[1]));

            CustomTuple<int, decimal> numbers =
                new CustomTuple<int, decimal>(int.Parse(numbersTokens[0]), decimal.Parse(numbersTokens[1]));

            Console.WriteLine(nameAdress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);
        }
    }
}
