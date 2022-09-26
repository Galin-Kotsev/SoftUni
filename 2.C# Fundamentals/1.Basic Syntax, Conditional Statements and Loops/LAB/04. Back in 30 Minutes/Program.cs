namespace _04._Back_in_30_Minutes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            int mm = minutes + 30;
            int hh = hours;

            if (mm >=60 )
            {
                hh++;
                mm-=60;

                if (hh >= 24)
                {
                    hh = 0;
                }
            }

            Console.WriteLine($"{hh}:{mm:d2}");
        }
    }
}
