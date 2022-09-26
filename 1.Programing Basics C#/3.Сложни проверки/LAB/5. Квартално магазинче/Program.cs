using System;

namespace _5._Квартално_магазинче
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double coffee = 0.45;
            double water = 0.70;
            double beer = 1.10;
            double sweets = 1.35;
            double peanuts = 1.55;


            if (city == "Varna") 
            {
                if (product == "coffee")
                {
                    Console.WriteLine(coffee * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(beer * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(sweets * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(peanuts * quantity);
                }
            }
            else if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine((coffee+0.05) * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine((water+0.10) * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine((beer+0.10) * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine((sweets+0.10) * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine((peanuts+0.05) * quantity);
                }
            }
            else
            {
                if (product == "coffee")
                {
                    Console.WriteLine((coffee - 0.05) * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine((beer + 0.05) * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine((sweets - 0.05) * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine((peanuts - 0.05) * quantity);
                }
            }
        }
    }
}
