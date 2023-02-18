using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack<string> customStack = new CustomStack<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command
                    .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = tokens[0];

                if (action == "Push")
                {
                    foreach (string item in tokens.Skip(1))
                    {
                        customStack.Push(item);
                    }
                }
                else if(action == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine(exeption.Message);
                    }
                }
            }

            foreach (string item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (string item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
