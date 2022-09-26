using System;

namespace _8._Обедна_почивка
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();
            double timeLaps = double.Parse(Console.ReadLine());
            double brakeLaps = double.Parse(Console.ReadLine());

            double lunchTime = brakeLaps * 1 / 8.0;
            double restTime = brakeLaps * 1 / 4.0;
            double timeLeft = brakeLaps - lunchTime - restTime;
            
            if (timeLeft>=timeLaps)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeLeft - timeLaps)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(timeLaps-timeLeft)} more minutes.");
            }

        }
    }




           

}
