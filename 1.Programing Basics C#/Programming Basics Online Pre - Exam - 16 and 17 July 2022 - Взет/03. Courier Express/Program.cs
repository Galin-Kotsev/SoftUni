using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double packegKG = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double price = 0;

            if (service == "standard")
            {
                if (packegKG < 1)
                {
                    price = distance* 0.03;
                }
                else if (packegKG >= 1 && packegKG <10)
                {
                    price = distance * 0.05;
                }
                else if (packegKG >=10 && packegKG <40)
                {
                    price = distance * 0.10;
                }
                else if (packegKG >= 40 && packegKG < 90)
                {
                    price = distance * 0.15;
                }
                else if (packegKG >= 90 && packegKG <= 150)
                {
                    price = distance * 0.20;
                }
            }
            else if (service == "express")
            {
                if (packegKG < 1)
                {
                    price = (((0.03 * 0.8) * packegKG) * distance) + distance * 0.03;
                }
                else if (packegKG >= 1 && packegKG < 10)
                {
                    price = (((0.05 * 0.4) * packegKG) * distance)+distance * 0.05;
                }
                else if (packegKG >= 10 && packegKG < 40)
                {
                    price = (((0.10 * 0.05) * packegKG) * distance)+distance * 0.10;
                }
                else if (packegKG >= 40 && packegKG < 90)
                {
                    price = (((0.15 * 0.02) * packegKG) * distance)+distance * 0.15;
                }
                else if (packegKG >= 90 && packegKG <= 150)
                {
                    price = (((0.20 * 0.01) * packegKG) * distance)+distance * 0.20;
                }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {packegKG:f3} kg. would cost {price:f2} lv.");
        }
    }
}
