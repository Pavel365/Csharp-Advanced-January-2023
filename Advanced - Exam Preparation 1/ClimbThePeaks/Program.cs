using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> peaks = new Dictionary<string, int>()
            {
                {"Vihren", 80 },
                {"Kutelo", 90 },
                {"Banski Suhodol", 100 },
                {"Polezhan", 60 },
                {"Kamenitza", 70 }
            };

            Queue<string> peaksNames = new Queue<string>(new List<string>{ "Vihren",
            "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza"});

            Stack<int> foodPortions = new Stack<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> staminaQuantities = new Queue<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<string> conqueredPeaks = new List<string>();

            while (foodPortions.Any() && staminaQuantities.Any() && peaksNames.Any())
            {
                int foodPortion = foodPortions.Pop();
                int staminaQuantity = staminaQuantities.Dequeue();

                int peakDifficulty = peaks[peaksNames.Peek()];

                if (foodPortion + staminaQuantity >= peakDifficulty)
                {
                    conqueredPeaks.Add(peaksNames.Dequeue());
                }
            }

            if (peaksNames.Any())
            {
                 Console.WriteLine("Alex failed! He has to organize his journey" +
                    " better next time -> @PIRINWINS");
            }
            else
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in " +
                    "one week -> @FIVEinAWEEK");
            }

            if (conqueredPeaks.Any())
            {
                Console.WriteLine("Conquered peaks:");

                foreach (string peak in conqueredPeaks)
                {
                    Console.WriteLine(peak);
                }
            }
        }
    }
}
