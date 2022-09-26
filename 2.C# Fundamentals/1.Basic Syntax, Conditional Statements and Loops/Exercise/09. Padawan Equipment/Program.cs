using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            int belt = 0;


            if (students >= 6)
            {
                int discount = students / 6;
                belt = students - discount;
            }
            else
            {
                belt = students;
            }

            double lightsaber = Math.Ceiling(students *1.1)*priceLightsaber;
            double robe = students * priceRobe;
            double belts = belt * priceBelt;

            double totalPrice = lightsaber + robe + belts;

            if (totalPrice > amountOfMoney)
            {
                double moneyNeeded = totalPrice - amountOfMoney;
                Console.WriteLine($" John will need {Math.Abs(moneyNeeded):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }

        }
    }
}
