using System;
using System.Collections.Generic;

namespace P._08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            HashSet<string> regularSet = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                set.Add(command);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (set.Contains(input))
                {
                    set.Remove(input);
                }
            }

            Console.WriteLine(set.Count);

            foreach (string guest in set)
            {
                char[] guestCh = guest.ToCharArray();
                if (char.IsDigit(guestCh[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (string guest in set)
            {
                char[] guestCh = guest.ToCharArray();
                if (char.IsLetter(guestCh[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
