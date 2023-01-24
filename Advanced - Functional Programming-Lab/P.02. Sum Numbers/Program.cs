using System;
using System.Linq;

namespace P._02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Sum());
        }

        static int Parse(string input)
        {
            return int.Parse(input);
        }
    }
}
