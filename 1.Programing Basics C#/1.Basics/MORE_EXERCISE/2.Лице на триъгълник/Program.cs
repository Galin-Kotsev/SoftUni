using System;

namespace _2.Лице_на_триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //area = a * h / 2
            double area = a * h / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
