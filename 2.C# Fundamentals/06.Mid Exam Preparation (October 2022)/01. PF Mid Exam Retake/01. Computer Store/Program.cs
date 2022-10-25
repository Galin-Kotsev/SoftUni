using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double partTax = 0;
            double totalPriceNoTax = 0;

            while (input != "special" && input != "regular")
            {
                double partPrice = double.Parse(input);

                if (partPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    partTax += partPrice * 0.20;
                    totalPriceNoTax += partPrice;
                }

                input = Console.ReadLine();
            }

            if (input == "special")
            {
                if (totalPriceNoTax == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    double totalPriceWithTax = (partTax + totalPriceNoTax) * 0.90;
                    Console.WriteLine($"Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceNoTax:f2}$");
                    Console.WriteLine($"Taxes: {partTax:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPriceWithTax:f2}$");
                }
            }
            else
            {
                if (totalPriceNoTax == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    Console.WriteLine($"Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceNoTax:f2}$");
                    Console.WriteLine($"Taxes: {partTax:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {partTax + totalPriceNoTax:f2}$");
                }
            }
        }
    }

}
