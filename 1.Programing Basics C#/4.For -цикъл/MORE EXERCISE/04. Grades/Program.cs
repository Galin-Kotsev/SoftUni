using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double topStudents = 0;
            double goodStudents = 0;
            double averageStudents = 0;
            double poorStudents = 0;
            double averageGrade = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                averageGrade += grade;

                if (grade >= 5)
                {
                    topStudents++;
                }
                else if (grade <= 4.99 && grade >= 4)
                {
                    goodStudents++;
                }
                else if (grade <= 3.99 && grade >= 3)
                {
                    averageStudents++;
                }
                else
                {
                    poorStudents++;
                }
            }
            double top = (topStudents / students)* 100;
            double good = (goodStudents / students) * 100;
            double average = (averageStudents / students) * 100;
            double poor = (poorStudents / students) * 100;

            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {average:f2}%");
            Console.WriteLine($"Fail: {poor:f2}%");
            Console.WriteLine($"Average: {(averageGrade/students):f2}");
        }
    }
}
