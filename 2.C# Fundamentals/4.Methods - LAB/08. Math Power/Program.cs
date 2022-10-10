using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(RiseToPower(a, b));
        }

        private static double RiseToPower(double a, double b)
        {
            double result = 0;

            result = Math.Pow(a, b);

            return result;
        }
    }
}
