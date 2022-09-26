using System;

namespace _4._Лодка_за_риболов
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double rent = 0;

            if (season == "Spring")
            {
                if (fisherman <= 6)
                {
                    rent = 3000 - (3000 * 0.10);
                }
                else if (fisherman >= 12)
                {
                    rent = 3000 - (3000 * 0.25);
                }
                else
                {
                    rent = 3000 - (3000 * 0.15);
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fisherman <= 6)
                {
                    rent = 4200 - (4200 * 0.10);
                }
                else if (fisherman >= 12)
                {
                    rent = 4200 - (4200 * 0.25);
                }
                else
                {
                    rent = 4200 - (4200 * 0.15);
                }
            }
            else
            {
                if (fisherman <= 6)
                {
                    rent = 2600 - (2600 * 0.10);
                }
                else if (fisherman >= 12)
                {
                    rent = 2600 - (2600 * 0.25);
                }
                else
                {
                    rent = 2600 - (2600 * 0.15);
                }
            }
            if (fisherman %2 == 0 && season != "Autumn")
            {
                rent = rent - (rent * 0.05);
            }
            else
            {
                rent = rent;
            }

            if (groupBudget >= rent)
            {
                Console.WriteLine($"Yes! You have {groupBudget-rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent - groupBudget:f2} leva.");
            }
        }
    }
}
