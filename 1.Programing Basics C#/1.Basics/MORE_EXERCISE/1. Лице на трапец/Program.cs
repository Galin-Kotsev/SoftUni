using System;

namespace _1._Лице_на_трапец
{
    class Program
    {
        static void Main(string[] args)
        {
          double b1 = double.Parse(Console.ReadLine());
          double b2 = double.Parse(Console.ReadLine());
          double h = double.Parse(Console.ReadLine());

            //(b1 + b2) * h / 2.
            double sum = (b1 + b2) * h / 2;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
