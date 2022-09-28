using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double invalid = 0;
            double number0to9 = 0;
            double number10to19 = 0;
            double number20to29 = 0;
            double number30to39 = 0;
            double number40to50 = 0;

            for (int i = 0; i < n; i++)
            {
                 int add = int.Parse(Console.ReadLine());


                if (add >= 0 && add <= 9)
                {
                    sum += add * 0.20;
                    number0to9++;
                }
                else if (add >= 10 && add <= 19)
                {
                    sum += add * 0.30;
                    number10to19++;
                }
                else if (add >= 20 && add <= 29)
                {
                    sum += add * 0.40;
                    number20to29++;

                }
                else if (add >= 30 && add <= 39)
                {
                    sum += 50;
                    number30to39++;
                }
                else if (add >= 40 && add<=50)
                {
                    sum += 100;
                    number40to50++;
                }
                else
                {
                    sum /= 2;
                    invalid++;
                }

            }

            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"From 0 to 9: {number0to9 / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {number10to19 / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {number20to29 / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {number30to39 / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {number40to50/n*100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid/n*100:f2}%");

        }
    }
}  