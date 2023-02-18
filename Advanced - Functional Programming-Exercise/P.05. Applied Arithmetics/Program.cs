using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, List<int>, List<int>> calculate = (command, numbrers) =>
            {
                List<int> result = new List<int>();
                foreach (int num in numbrers)
                {
                    switch (command)
                    {
                        case "add":
                            result.Add(num + 1);
                            break;
                        case "multiply":
                            result.Add(num * 2);
                            break;
                        case "subtract":
                            result.Add(num - 1);
                            break;
                    }
                }

                return result;
            };

            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));


            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    numbers = calculate(command, numbers);
                }
            }
        }
    }
}
