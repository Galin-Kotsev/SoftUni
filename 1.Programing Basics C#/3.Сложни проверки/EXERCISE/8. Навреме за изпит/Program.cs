using System;

namespace _8._Навреме_за_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            examHour = examHour * 60;
            int examTime = examHour + examMinute;

            arrivalHour = arrivalHour * 60;
            int arrivalTime = arrivalHour + arrivalMinute;

            if (examTime<arrivalTime)
            {
                int timeLate = arrivalTime - examTime;
                if (timeLate >= 60)
                {
                    int timeLateA = timeLate / 60;
                    int timeLateB = timeLate % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{timeLateA}:{timeLateB:d2} hours after the start");
                }
                else
                {
                    timeLate = timeLate % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(timeLate)} minutes after the start");
                }
            }
            else if (arrivalTime < examTime-30)
            {
                int timeLate = examTime - arrivalTime;

                if (timeLate >= 60)
                {
                    int timeLateA = timeLate / 60;
                    int timeLateB = timeLate % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{timeLateA}:{timeLateB:d2} hours before the start");
                }
                else
                {
                    timeLate = timeLate % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{Math.Abs(timeLate)} minutes before the start");
                }
            }
            else
            {
                int timeLate = examTime - arrivalTime;

                if (timeLate >= 60)
                {
                    int timeLateA = timeLate / 60;
                    int timeLateB = timeLate % 60;
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{timeLateA}:{timeLateB:d2} hours before the start");
                }
                else if (timeLate == 0)
                {
                    timeLate = timeLate % 60;
                    Console.WriteLine("On Time");
                   
                }
                else 
                {
                    timeLate = timeLate % 60;
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{Math.Abs(timeLate)} minutes before the start");
                }
            }

        }
    }
}
