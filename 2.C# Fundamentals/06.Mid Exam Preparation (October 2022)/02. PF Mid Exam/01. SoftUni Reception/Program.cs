using System;
using System.Xml.Schema;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeTree = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int hours = 0;
            int count = 0;

            int servedPerHour = employeeOne + employeeTwo + employeeTree;
            
            for (int i = studentsCount; i > 0; i -= servedPerHour)
            {
                hours++;

                if (hours%4 == 0)
                {
                    hours++;
                }
                
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
