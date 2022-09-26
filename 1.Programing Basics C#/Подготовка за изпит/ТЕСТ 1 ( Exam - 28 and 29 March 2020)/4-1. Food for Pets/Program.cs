using System;

namespace _4_1._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodAmount = double.Parse(Console.ReadLine());
            

            int dogTotal = 0;
            int catTotal = 0;
            double biscuits = 0;
            
            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                dogTotal += dogFood;
                catTotal += catFood;

                if (i % 3 == 0)
                {
                    biscuits += (dogFood + catFood) / 10.0;
                }
            }
            double foodEaten = catTotal + dogTotal;
            
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{(foodEaten*100)/foodAmount:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogTotal*100)/ foodEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{(catTotal * 100) / foodEaten:f2}% eaten from the cat.");
        }
    }
}
