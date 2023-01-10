using System;
using System.Collections.Generic;

namespace P._06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cusomsNames = new Queue<string>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (cusomsNames.Count != 0)
                    {
                        Console.WriteLine(cusomsNames.Dequeue());
                    }
                }
                else
                {
                    cusomsNames.Enqueue(command);
                }
            }

            Console.WriteLine($"{cusomsNames.Count} people remaining.");
        }
    }
}
