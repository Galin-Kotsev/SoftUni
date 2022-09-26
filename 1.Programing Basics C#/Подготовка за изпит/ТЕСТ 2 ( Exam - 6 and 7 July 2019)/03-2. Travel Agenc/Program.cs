using System;

namespace _03_2._Travel_Agenc
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string equipment = Console.ReadLine();
            string vip = Console.ReadLine();
            int daysStay = int.Parse(Console.ReadLine());
            double price = 0;

            if (daysStay > 7)
            {
                daysStay -= 1;
            }
            else if (daysStay < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            if (destination == "Bansko" || destination == "Borovets")
            {
                if (equipment == "withEquipment")
                {
                    price = daysStay * 100;
                    if (vip == "yes")
                    {
                        price *= 0.90;
                    }
                }
                else if (equipment == "noEquipment")
                {
                    price = daysStay * 80;
                    if (vip == "yes")
                    {
                        price *= 0.95;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if (destination == "Varna" || destination == "Burgas")
            {
                if (equipment == "withBreakfast")
                {
                    price = daysStay * 130;
                    if (vip == "yes")
                    {
                        price *= 0.88;
                    }
                }
                else if (equipment == "noBreakfast")
                {
                    price = daysStay * 100;
                    if (vip == "yes")
                    {
                        price *= 0.93;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
        }
    }
}
