using System;
using System.Collections.Generic;
using System.Linq;

namespace P._05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                people.Add(new Person() { Name = input[0], age = int.Parse(input[1]) });
            }

            string filterType = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());

            Func<Person, int, bool> filter = GrtFilter(filterType);

            people = people.Where(p => filter(p, filterValue)).ToList();

            Action<Person> formatter = GetFormater(Console.ReadLine());

            foreach (var person in people)
            {
                formatter(person);
            }


            Func<Person, int, bool> GrtFilter(string filterType)
            {
                if (filterType == "younger")
                {
                    return (p, value) => p.age < value;
                }
                else
                {
                    return(Person p, int value) => p.age >= value;
                }
            }

            Action <Person> GetFormater(string formatType)
            {
                if (formatType == "name age")
                {
                    return p => Console.WriteLine($"{p.Name} - {p.age}");
                }
                else if (formatType == "name")
                {
                    return p => Console.WriteLine($"{p.Name}");
                }
                else if(formatType == "age")
                {
                    return p => Console.WriteLine($"{p.age}");
                }

                return null;
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }    
        public int age { get; set; }
    }
}
