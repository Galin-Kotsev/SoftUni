using System;

namespace _4._инчове_към_сантиметри
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double sm = a * 2.54;
            Console.WriteLine(sm);
        }
    }
}
