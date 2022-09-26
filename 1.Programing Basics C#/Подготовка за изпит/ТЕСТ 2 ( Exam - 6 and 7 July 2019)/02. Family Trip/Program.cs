using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            double cureentBudjet = double.Parse(Console.ReadLine());
            int nightStay = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int extraSpendings = int.Parse(Console.ReadLine());
            double totalAmount;

            if (nightStay > 7)
            {
                double discount = pricePerNight * 0.95;
                double stayPrice = discount * nightStay;
                double spendings = cureentBudjet * extraSpendings / 100;
                totalAmount = stayPrice + spendings;
            }
            else
            {
                double stayPrice = pricePerNight * nightStay;
                double spendings = cureentBudjet * extraSpendings / 100;
                totalAmount = stayPrice + spendings;
            }

            if (totalAmount <= cureentBudjet)
            {
                Console.WriteLine($"Ivanovi will be left with {cureentBudjet - totalAmount:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalAmount - cureentBudjet:f2} leva needed.");
            }
        }
    }
}
