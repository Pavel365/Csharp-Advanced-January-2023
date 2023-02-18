using System;

namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();

                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
