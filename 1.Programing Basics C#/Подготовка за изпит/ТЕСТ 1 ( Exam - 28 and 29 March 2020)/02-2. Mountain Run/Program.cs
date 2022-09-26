using System;

namespace _02_2._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondForMeter = double.Parse(Console.ReadLine());

            double distance = distanceInMeters * secondForMeter;
            double delay = Math.Floor(distanceInMeters / 50)*30;
            double TotalTime = distance + delay;
            double time = recordSec - TotalTime;
            if (recordSec <= TotalTime)
            {
                Console.WriteLine($"No! He was {Math.Abs(time):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes! The new record is {Tota                       lTime:f2} seconds.");
            }


        }
    }
}
