using System;

namespace _2._Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int offWorkworkDays = x * 127;
            int workDays = (365 - x) * 63;
            int totalDays = offWorkworkDays + workDays;
            int timeLeft = 30000 - totalDays;
            int hours = timeLeft / 60;
            int minutes = timeLeft % 60;
            minutes = Math.Abs(minutes);
            hours = Math.Abs(hours);
            if (30000 <= totalDays)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");

            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");

            }
        }
    }
}
