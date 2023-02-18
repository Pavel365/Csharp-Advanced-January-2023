namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var universe = Console.ReadLine()
                  .Split(", ")
                  .Select(int.Parse)
                  .ToList();

            var numOfSets = int.Parse(Console.ReadLine());
            var sets = new List<int[]>();
            for (int i = 0; i < numOfSets; i++)
            {
                sets.Add(Console.ReadLine()
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray());
            }

            var selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                var currentSet = sets
                    .OrderByDescending(s => s.Count(e => universe.Contains(e)))
                    .FirstOrDefault();

                selectedSets.Add(currentSet);
                sets.Remove(currentSet);

                foreach (var element in currentSet)
                {
                    universe.Remove(element);
                }
            }

            Console.WriteLine($"Sets to take ({selectedSets.Count}):");
            foreach (var set in selectedSets)
            {
                Console.Write("{ ");
                Console.WriteLine(string.Join(", ", set) + " }");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            return null;
        }
    }
}
