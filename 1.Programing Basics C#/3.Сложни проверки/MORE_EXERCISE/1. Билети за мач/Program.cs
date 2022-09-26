using System;

namespace _1._Билети_за_мач
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string tickedType = Console.ReadLine();
            int person = int.Parse(Console.ReadLine());
            double moneyLeft = 0;

            if (tickedType == "VIP")
            {
                if (person <= 4)
                {
                    budget -= (budget * 0.75);

                }
                else if (person >= 5 && person <= 9)
                {
                    budget -= (budget * 0.60);
                }
                else if (person >= 10 && person <= 24)
                {
                    budget -= (budget * 0.50);
                }
                else if (person >= 25 && person <= 49)
                {
                    budget -= (budget * 0.40);
                }
                else
                {
                    budget -= (budget * 0.25);
                }

                moneyLeft = budget - (person * 499.99);

                if (moneyLeft >= 0)
                {
                    Console.WriteLine($"Yes! You have {Math.Abs(moneyLeft):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
                }

            }
            else if (tickedType == "Normal")
            {
                if (person <= 4)
                {
                    budget -= (budget * 0.75);

                }
                else if (person >= 5 && person <= 9)
                {
                    budget -= (budget * 0.60);
                }
                else if (person >= 10 && person <= 24)
                {
                    budget -= (budget * 0.50);
                }
                else if (person >= 25 && person <= 49)
                {
                    budget -= (budget * 0.40);
                }
                else
                {
                    budget -= (budget * 0.25);
                }

                moneyLeft = budget - (person * 249.99);

                if (moneyLeft >= 0)
                {
                    Console.WriteLine($"Yes! You have {Math.Abs(moneyLeft):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
                }
            } 
        }
    }
}
