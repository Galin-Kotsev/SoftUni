using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputs = input.Split();
                string firstName = inputs[0];   
                string lastName = inputs[1];
                double grade = double.Parse(inputs[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}
