using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int santaGone = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double firstDeer = double.Parse(Console.ReadLine());
            double secondDeer = double.Parse(Console.ReadLine());
            double thirdDeer = double.Parse(Console.ReadLine());

            double firsttDeerFood = santaGone * firstDeer;
            double secondDeerFood = santaGone * secondDeer;
            double thirdDeerFood = santaGone * thirdDeer;
            double foodTotal = firsttDeerFood + secondDeerFood + thirdDeerFood;

            if (foodLeftKg >= foodTotal)
            {
                Console.WriteLine($"{Math.Floor(foodLeftKg - foodTotal)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodTotal - foodLeftKg)} more kilos of food are needed.");
                
            }
        }
    }
}
