using System;

namespace _8._Резервоар_за_гориво____част_2__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double Gas = 0.93;
            double Gasoline = 2.22;
            double Diesel = 2.33;
            double totalPrice = 0;
            

            if (clubCard == "Yes")
            {
                if (fuelType == "Gas")
                {
                    totalPrice = 0.85 * liters;
                }
                else if (fuelType == "Gasoline")
                {
                    totalPrice = 2.04 * liters;
                }
                else
                {
                    totalPrice = 2.21 * liters;
                }
            }
            else
            {
                if (fuelType == "Gas")
                {
                    totalPrice = Gas * liters;
                }
                else if (fuelType == "Gasoline")
                {
                    totalPrice = Gasoline * liters;
                }
                else
                {
                    totalPrice = Diesel * liters;
                }
                
            }


            if (liters >= 20 && liters <= 25)
            {
                totalPrice = totalPrice - (totalPrice * 0.08);
            }
            else if (liters > 25)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
