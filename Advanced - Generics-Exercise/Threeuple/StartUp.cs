using System;
using System.Linq;

namespace Threeuple
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

            string[] bankTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            CustomThreeuple<string, string, string> nameAdress =
                new CustomThreeuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

            CustomThreeuple<string, int, bool> drinks =
                new CustomThreeuple<string, int, bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

            CustomThreeuple<string, double, string> banks =
                new CustomThreeuple<string, double, string>(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(nameAdress);
            Console.WriteLine(drinks);
            Console.WriteLine(banks);
        }
    }
}
