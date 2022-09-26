using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double DFP = 2.5;
            double CFP = 4;

            int dogFood = int.Parse(Console.ReadLine());
            int CatFood = int.Parse(Console.ReadLine());

            double sum = (dogFood * DFP) + (CatFood * CFP);
            Console.WriteLine($"{sum} lv.");
        }
    }
}
