using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());

                box.Add(item);
            }

            int[] indicates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(indicates[0], indicates[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
