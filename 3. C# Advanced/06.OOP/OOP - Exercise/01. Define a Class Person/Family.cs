using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public Family() 
        { 
            people = new List<Person>();
        }

        public void AddMember()
        {
                string[] inputs = Console.ReadLine().Split(" ");
                string name = inputs[0];
                int age = int.Parse(inputs[1]);
                Person person = new Person(name, age);
                people.Add(person);
        }

        public void GetOldestMember()
        {
            Console.WriteLine(string.Join(" ", people.OrderByDescending(x => x.Age).Take(1)));
        }

        public void GetOldestMembers()
        {
            foreach (Person person in people.OrderBy(x => x.Name))
            {

                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            
        }

    }
}



