using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(v => int.Parse(v))
                .ToList();

            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
