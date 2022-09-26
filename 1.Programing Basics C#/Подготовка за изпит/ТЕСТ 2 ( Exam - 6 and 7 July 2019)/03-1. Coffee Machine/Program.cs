using System;

namespace _03_1._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price = 0;
            
            if (drink == "Espresso")
            {
                if (sugar == "Normal")
                {
                    price = amount * 1;
                }
                else if (sugar == "Without")
                {
                    price = (amount * 0.9) * 0.65;
                }
                else if (sugar == "Extra")
                {
                    price = amount * 1.20;
                }

                if (amount >= 5)
                {
                    price *= 0.75;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Normal")
                {
                    price = amount * 1.2;
                }
                else if (sugar == "Without")
                {
                    price = (amount * 1) * 0.65;
                }
                else if (sugar == "Extra")
                {
                    price = amount * 1.6;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Normal")
                {
                    price = amount * 0.60;
                }
                else if (sugar == "Without")
                {
                    price = (amount * 0.50) * 0.65;
                }
                else if (sugar == "Extra")
                {
                    price = amount * 0.70;
                }
            }

            if (price > 15.00)
            {
                price *= 0.80;
            }
            Console.WriteLine($"You bought {amount} cups of {drink} for {price:f2} lv.");
        }
    }
}
