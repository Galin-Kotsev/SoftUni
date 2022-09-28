using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int ivanAge = 18;
            double moneyBudget = money;
            

            for (int i = 1800; i <= year; i++)
            {
               
                if (i%2 == 0)
                {
                    moneyBudget -= 12_000;
                }
                else
                {
                    moneyBudget -= 12_000 + (ivanAge * 50);
                }

                ivanAge++;
            }

            if (moneyBudget >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyBudget:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyBudget):f2} dollars to survive.");
            }
        }
    }
}
