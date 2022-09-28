using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double fansAmount = double.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;


            for (int i = 0; i < fansAmount; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            double amountA = (sectorA / fansAmount) * 100;
            double amountB = (sectorB / fansAmount) * 100;
            double amountV = (sectorV / fansAmount) * 100;
            double amountG = (sectorG / fansAmount) * 100;
            double capacity = (fansAmount / stadiumCapacity) * 100;


            Console.WriteLine($"{amountA:f2}%");
            Console.WriteLine($"{amountB:f2}%");
            Console.WriteLine($"{amountV:f2}%");
            Console.WriteLine($"{amountG:f2}%");
            Console.WriteLine($"{capacity:f2}%");

        }
    }
}
