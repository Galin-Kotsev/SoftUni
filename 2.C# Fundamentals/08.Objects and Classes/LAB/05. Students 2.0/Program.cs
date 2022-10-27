using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string inputInformation = Console.ReadLine();

            while (inputInformation != "end")
            {
                string[] credentials = inputInformation.Split(' ');

                string firsName = credentials[0];
                string lastName = credentials[1];
                int age = int.Parse(credentials[2]);
                string town = credentials[3];

                if (students.Any(x => x.FirstName == firsName && x.LastName == lastName))
                {
                    Student student = students.First(x => x.FirstName == firsName && x.LastName == lastName);
                    student.FirstName = firsName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = town;

                }
                else
                {
                    Student student = new Student(firsName, lastName, age, town);
                    students.Add(student);
                }

                inputInformation = Console.ReadLine();
            }

            string InputedTown = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == InputedTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
