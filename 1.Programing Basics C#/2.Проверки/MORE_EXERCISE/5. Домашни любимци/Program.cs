using System;

namespace _5._Домашни_любимци
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turleFood = double.Parse(Console.ReadLine());

            double dog = days * dogFood;
            double cat = days * catFood;
            double turtle = days * turleFood / 1000;
            double totalFood = dog + cat + turtle;
            double foodLeft = foodKg - totalFood;
            foodLeft = Math.Abs(foodLeft);

            if (totalFood<=foodKg)
            {
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
