using System;

namespace _5._Годзила_срещу_Конг
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extras = double.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            
            double costumes = 0;

            
            if (extras <= 150)
            {
                costumes = extras * costumePrice;
                double sumMovie = decor + costumes;
                double money = budget - sumMovie;
                if (sumMovie <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {money:f2} leva left.");
                }
                else
                {
                    money = Math.Abs(money);
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {money:f2} leva more.");
                }

            }
            else 
            {
                
                costumes = (extras * costumePrice);
                double costumesDisc = costumes;
                costumesDisc = costumes * 0.10;
                double costumes2 = costumes - costumesDisc;
                double sumMovie = decor + costumes2;
                double money = budget - sumMovie;


                if (sumMovie <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {money:f2} leva left.");
                }
                else
                {
                    money = Math.Abs(money);
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {money:f2} leva more.");
                }


            }

        }

    }






}
