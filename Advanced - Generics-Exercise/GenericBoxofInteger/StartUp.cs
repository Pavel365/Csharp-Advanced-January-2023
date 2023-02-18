using System;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());

                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
