using System;

namespace _3._Време___15_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());   
            int minute = int.Parse(Console.ReadLine()); 

            int time = minute + hour * 60 + 15;          
            int hours = time / 60;   
            int minutes = time % 60;

            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
