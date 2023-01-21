using System;
using System.Collections.Generic;
using System.Linq;

namespace P._02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }

                studentGrades[studentName].Add(grade);
            }

            foreach (var studentGrade in studentGrades)
            {
                Console.Write($"{studentGrade.Key} -> ");
                foreach (var grade in studentGrade.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {studentGrade.Value.Average():F2})");
            }
        }
    }
}
