using System;
using System.Collections.Generic;

namespace _3._Реколта
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grape = x * y;
            double wine = grape * 0.40 / 2.5;
            double totalL= wine - z;
            double winePerPerson = totalL / workers;

           

            if (wine >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalL)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");

            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z-wine)} liters wine needed.");
                
            }

        }
    }
}
