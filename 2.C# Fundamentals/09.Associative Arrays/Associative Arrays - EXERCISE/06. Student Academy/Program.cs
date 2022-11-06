using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var gradesList = new Dictionary<string, List<double>>();
            
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();  
                double grade = double.Parse(Console.ReadLine());

                if (!gradesList.ContainsKey(student))
                {
                    gradesList.Add(student, new List<double>());
                }

                gradesList[student].Add(grade);
            }

            foreach (var (Key, Value) in gradesList)
            {
                if (Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{Key} -> {Value.Average():f2}");
                }
            }
        }
    }
}





