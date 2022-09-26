using System;

namespace _5._Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string vacantionType = "";
            string location = "";
            double money = 0;

            if (budget <= 100)
            {
                location = "Bulgaria";
                
                if (season == "summer")
                {
                    vacantionType = "Camp";
                    money = budget * 0.30;
                }
                else
                {
                    vacantionType = "Hotel";
                    money = budget * 0.70;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                   location = "Balkans";
                if (season == "summer")
                {
                    vacantionType = "Camp";
                    money = budget * 0.40;
                }
                else
                {
                    vacantionType = "Hotel";
                    money = budget * 0.80;
                }
            }
            else
            {
                location = "Europe";
                vacantionType = "Hotel";
                money = budget * 0.90;

            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{vacantionType} - {money:f2}");
        }
    }
}
