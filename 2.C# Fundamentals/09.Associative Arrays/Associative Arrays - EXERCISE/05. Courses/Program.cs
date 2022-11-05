using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] inputs = input.Split(" : ");
                string course = inputs[0];
                string student = inputs[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);

                input = Console.ReadLine();
            }

            foreach (var (course, students) in courses)
            {
                Console.WriteLine($"{course}: {students.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
