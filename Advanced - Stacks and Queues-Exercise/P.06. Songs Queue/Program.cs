using System;
using System.Collections.Generic;
using System.Linq;

namespace P._06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] song = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue <string> songs = new Queue<string>(song);

            while (songs.Count != 0)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string newSong = string.Join(" ", tokens.Skip(1));

                    if (songs.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                        continue;
                    }

                    songs.Enqueue(newSong);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
