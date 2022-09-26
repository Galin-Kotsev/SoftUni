using System;

namespace _8.Лице_на_Кръг
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            // A = πr2
            double area = Math.PI * r * r;
            
            // Р= 2.π.r 
            double perimetre = 2 * Math.PI * r;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimetre:f2}");
        }
    }
}
