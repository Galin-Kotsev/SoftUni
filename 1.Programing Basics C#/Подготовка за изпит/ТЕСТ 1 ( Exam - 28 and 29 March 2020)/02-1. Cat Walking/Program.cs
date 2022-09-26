using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            double calPerDay = double.Parse(Console.ReadLine());

            double burnedCal = (walksPerDay * minutesWalk)*5;
            double calPerWalk = calPerDay / 2;

            if (burnedCal >= calPerWalk)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCal}.");
            }
        }
    }
}
