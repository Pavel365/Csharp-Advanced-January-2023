using System;
using System.Collections.Generic;
using System.Linq;

namespace P._09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> participantsPoints = new SortedDictionary<string, int>();
            SortedDictionary<string, int> languagesSubmissions = new SortedDictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = command
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];

                if (tokens[1] == "banned")
                {
                    participantsPoints.Remove(name);
                    continue;
                }

                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!participantsPoints.ContainsKey(name))
                {
                    participantsPoints.Add(name, 0);
                }

                if (participantsPoints[name] < points)
                {
                    participantsPoints[name] = points;
                }
                
                if (!languagesSubmissions.ContainsKey(language))
                {
                    languagesSubmissions.Add(language, 0);
                }

                languagesSubmissions[language]++;
            }

            Dictionary<string, int> orderedParticipantPoints = participantsPoints
                .OrderByDescending(p => p.Value)
                .ToDictionary(p => p.Key, p => p.Value);

            Console.WriteLine("Results:");
            foreach (var participantPoints in orderedParticipantPoints)
            {
                Console.WriteLine($"{participantPoints.Key} | {participantPoints.Value}");
            }

            Dictionary<string, int> orderedLanguagesSubmissions = languagesSubmissions
                .OrderByDescending(l => l.Value)
                .ToDictionary(l => l.Key, l => l.Value);

            Console.WriteLine("Submissions:");
            foreach (var languageSubmissions in orderedLanguagesSubmissions)
            {
                Console.WriteLine($"{languageSubmissions.Key} - {languageSubmissions.Value}");
            }
        }
    }
}
