using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int add = int.Parse(Console.ReadLine());
                sum += add;

            }

            Console.WriteLine($"{sum / n:f2}");
        }
    }
}
