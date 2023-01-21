using System;
using System.Collections.Generic;

namespace P._01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string userName = Console.ReadLine();

                userNames.Add(userName);
            }

            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }

        }
    }
}
