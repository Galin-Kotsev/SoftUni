using System;

namespace _7._Резервоар_за_гориво
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            int liters = int.Parse(Console.ReadLine());
            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")

            {
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
} 
