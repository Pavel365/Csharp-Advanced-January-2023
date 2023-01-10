using System;
using System.Collections.Generic;
using System.Linq;

namespace P._02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();  

            Stack<int> stack = new Stack<int>(input);

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "add")
                {
                    int first = int.Parse(cmdArgs[1]);
                    int second = int.Parse(cmdArgs[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else if (cmdArgs[0] == "remove")
                {
                    int n = int.Parse(cmdArgs[1]);

                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;

            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
