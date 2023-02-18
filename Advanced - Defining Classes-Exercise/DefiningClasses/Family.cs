using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People { get { return this.people; } set { this.people = value; } }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public List<Person> GetPeopleOlderThan30(List<Person> people)
        {
            List<Person> older = new List<Person>();
            foreach (var person in people)
            {
                if (person.Age > 30)
                {
                    older.Add(person);
                }
            }
            older = older.OrderBy(person => person.Name).ToList();   
            return older;
        }
    }
}
