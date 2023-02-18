using System;

namespace DateModifier
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int getDifferenceInDays = DateModifier.GetDifferenceInDays(start, end);

            Console.WriteLine(getDifferenceInDays);
        }
    }
}
