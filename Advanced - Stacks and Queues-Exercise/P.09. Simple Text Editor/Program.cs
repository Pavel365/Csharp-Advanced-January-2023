using System;
using System.Collections.Generic;
using System.Linq;

namespace P._09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Stack<string> changes = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int command = int.Parse(tokens[0]);

                if (command == 1)
                {
                    changes.Push(text);
                    text += tokens[1];
                }
                else if (command == 2)
                {
                    changes.Push(text);
                    int coumting = int.Parse(tokens[1]);
                    text = text.Remove(text.Length - coumting); 
                }
                else if (command == 3)
                {
                    int index = int.Parse(tokens[1]) -1;
                    Console.WriteLine(text[index]);
                }
                else if (command == 4)
                {
                    if (changes.Any())
                    {
                        text = changes.Pop();
                    }
                }
            }
        }
    }
}
