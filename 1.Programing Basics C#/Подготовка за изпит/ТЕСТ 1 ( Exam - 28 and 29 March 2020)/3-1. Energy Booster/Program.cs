using System;

namespace _3_1._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            double productPrice = 0;
            double discount = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    productPrice = (56 * 2) * amount;
                }
                else if (size == "big")
                {
                    productPrice = (28.70 * 5) * amount;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    productPrice = (36.66 * 2) * amount;
                }
                else if (size == "big")
                {
                    productPrice = (19.60 * 5) * amount;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    productPrice = (42.10 * 2) * amount;
                }
                else if (size == "big")
                {
                    productPrice = (24.80 * 5) * amount;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    productPrice = (20 * 2) * amount;
                }
                else if (size == "big")
                {
                    productPrice = (15.20 * 5) * amount;
                }
            }

            if (productPrice >= 400 && productPrice <= 1000)
            {
                discount = productPrice *0.15;
                productPrice -= discount;
                double endPrice = productPrice;
                Console.WriteLine($"{productPrice:f2} lv.");
            }
            else if (productPrice > 1000)
            {
                discount = productPrice * 0.50;
                productPrice -= discount;
                double endPrice = productPrice;
                Console.WriteLine($"{productPrice:f2} lv.");
            }
            else
            {
                double endPrice = productPrice;
                Console.WriteLine($"{productPrice:f2} lv.");
            }
        }
    }
}
