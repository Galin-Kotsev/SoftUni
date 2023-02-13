using System;
using System.Collections.Generic;
using System.Linq;

namespace Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> miligrams
               = new Stack<int>(Console.ReadLine()
               .Split(", ")
               .Select(int.Parse));

            Queue<int> energyDrinks
                = new Queue<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse));

            int totalCoffein = 0;


            
            while (miligrams.Any() && energyDrinks.Any())
            {
                int drink = miligrams.Peek() * energyDrinks.Peek();
                
                if (totalCoffein + drink <= 300)
                {
                    totalCoffein += drink;
                    miligrams.Pop();
                    energyDrinks.Dequeue();
                }
                else
                {
                    int currDrink = energyDrinks.Peek();

                    if (totalCoffein >= 30)
                    {
                        totalCoffein -= 30;
                    }
                    else
                    {
                        totalCoffein = 0;
                    }

                    miligrams.Pop();
                    energyDrinks.Dequeue();
                    energyDrinks.Enqueue(currDrink);
                }
            }

            if(energyDrinks.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",energyDrinks)}");
                Console.WriteLine($"Stamat is going to sleep with {totalCoffein} mg caffeine.");
            }
            else
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
                Console.WriteLine($"Stamat is going to sleep with {totalCoffein} mg caffeine.");
            }
        }

    }
}
