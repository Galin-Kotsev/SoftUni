using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{number[i]} => {(int)Math.Round(number[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
