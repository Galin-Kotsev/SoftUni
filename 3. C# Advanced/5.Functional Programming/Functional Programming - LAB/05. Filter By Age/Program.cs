using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new Person(name, age));
            }

            string filterType = Console.ReadLine();

            int filterValue = int.Parse(Console.ReadLine());

            Func<Person, int, bool> filter = GetFilter(filterType);

            people = people.Where(p => filter(p, filterValue)).ToList();

            Action<Person> formatter = GetFormatter(Console.ReadLine());

            foreach (Person person in people)
            { 
                formatter(person);
            }


            Func<Person, int, bool> GetFilter(string filterType)
            {
                if (filterType == "younger")
                {
                    return (p, value) => p.Age < value;
                }
                else
                {
                    return (p, value) => p.Age >= value;
                }

            }

            Action<Person> GetFormatter(string formatType) 
            {
                if(formatType == "name age")
                {
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
                }

                if(formatType == "name")
                {
                    return p => Console.WriteLine($"{p.Name}");
                }

                if(formatType == "age")
                {
                    return p => Console.WriteLine($"{p.Age}");
                }
                return null;
            }

        }
    }
}


class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name;
    public int Age;
}
