using System;

namespace _6._Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = double.Parse(Console.ReadLine());
           double meters = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());
          
            
            double totalTime = 0;
            double time = 0;
            double distance = meters * timeSeconds;
            double metersAdded = Math.Floor(meters / 15) * 12.5;
            totalTime = distance + metersAdded;
            time = totalTime - seconds;

            if (seconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {time:f2} seconds slower.");
            }
            else
            {
                 Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}

