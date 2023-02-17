using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals
                = new Queue<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));

            Stack<int> calories
                = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int currDay = calories.Peek();

            int totalMeals = 0;

            while (true)
            {
                if (meals.Count == 0 || calories.Count == 0)
                {
                    break;
                }

                totalMeals++;

                string meal = meals.Dequeue();

                if (meal == "salad")
                {
                    currDay -= 350;
                }

                if (meal == "soup")
                {
                    currDay -= 490;
                }

                if (meal == "pasta")
                {
                    currDay -= 680;
                }

                if (meal == "steak")
                {
                    currDay -= 790;
                }

                if (currDay <= 0)
                {
                    calories.Pop();

                    if (calories.Count == 0 )
                    {
                        break;
                    }

                    currDay += calories.Peek();
                }

            }

            List<string> mealtsLeft = new List<string>();

            foreach (string meal in meals)
            {
                mealtsLeft.Add(meal);
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {totalMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {currDay}, {string.Join(", ", calories.Skip(1))} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {totalMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealtsLeft)}.");

            }
        }
    }
}
