using System;

namespace _01.Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int citys = int.Parse(Console.ReadLine());

            int visits = 0;
            double totalEarnings = 0;

            for (int i = 0; i < citys; i++)
            {

                string city = Console.ReadLine();
                double earnings = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                visits++;

                if (visits % 3 == 0 && visits != 15)
                {
                    earnings -= expenses + (expenses * 0.50);
                    totalEarnings += earnings;
                    Console.WriteLine($"In {city} Burger Bus earned {earnings:f2} leva.");
                }
                else if (visits % 5 == 0)
                {
                    earnings *= 0.90;
                    earnings -= expenses;
                    totalEarnings += earnings;
                    Console.WriteLine($"In {city} Burger Bus earned {earnings:f2} leva.");

                }
                else
                {
                    earnings -= expenses;
                    totalEarnings += earnings;
                    Console.WriteLine($"In {city} Burger Bus earned {earnings:f2} leva.");

                }

            }

            Console.WriteLine($"Burger Bus total profit: {totalEarnings:f2} leva.");
        }
    }
}



