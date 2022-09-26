using System;

namespace _5_1._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000;
            string command = Console.ReadLine();

            double puppyFood = 0;

           while (command != "Adopted")
            {
                int added = int.Parse(command);


                puppyFood += added;

                command = Console.ReadLine();
            }

            double foodLeft = food - puppyFood;

            if (food >= puppyFood)
            {
                
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodLeft)} grams more.");
            }
        }
    }
}
