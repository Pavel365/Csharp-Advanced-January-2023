using System;
using System.Collections.Generic;

namespace P._08._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue <string> cars = new Queue<string>();

            int count = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        count++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
