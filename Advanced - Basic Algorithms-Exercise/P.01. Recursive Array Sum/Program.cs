using System;
using System.Linq;

namespace P._01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)  
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(ArraySum(arr,0));
        }

        static int ArraySum(int[] array, int index)
        {
            if (index >= array.Length)
            {
                return 0;
            }

            return array[index] + ArraySum(array, index + 1);
        }
    }
}
