using System;
using System.Linq;

namespace P._11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, int, bool> checkEqualOrLargerNameSum = (name, sum) 
                => name.Sum(ch => ch) >= sum;

            Func<string[], int, Func<string, int, bool>, string> getFirstName =
                (name, sum, match) => name.FirstOrDefault(name => match(name, sum));

            Console.WriteLine(getFirstName(names, sum, checkEqualOrLargerNameSum));
        }
    }
}
