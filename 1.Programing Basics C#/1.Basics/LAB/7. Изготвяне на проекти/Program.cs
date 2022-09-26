using System;

namespace _7._Изготвяне_на_проекти
{
    class Program
    {
        static void Main(string[] args)
        {
            string arcName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int workHours = projects * 3;

            Console.WriteLine($"The architect {arcName} will need {workHours} hours to complete {projects} project/s.");
        }
    }
}
