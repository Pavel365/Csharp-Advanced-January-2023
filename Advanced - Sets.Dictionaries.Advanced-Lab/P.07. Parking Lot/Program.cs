using System;
using System.Collections.Generic;
using System.Linq;

namespace P._07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction == "IN")
                {
                    carPlates.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    carPlates.Remove(carNumber);
                }
            }

            if (carPlates.Any())
            {
                foreach (string carPlate in carPlates)
                {
                    Console.WriteLine(carPlate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
