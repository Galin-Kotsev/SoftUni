using System;

namespace _7._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studio = 0;
            double apartmen = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    studio = 50 * nights;
                    studio = studio - (studio * 0.05);
                    apartmen = 65 * nights;
                }
                else if (nights > 14)
                {
                    studio = 50 * nights;
                    studio = studio - (studio * 0.30);
                    apartmen = 65 * nights;
                    apartmen = apartmen - (apartmen * 0.10);
                }
                else
                {
                    studio = 50 * nights;
                    apartmen = 65 * nights;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    studio = 75.20 * nights;
                    apartmen = 68.70 * nights;
                    
                }
                else 
                {
                    studio = 75.20 * nights;
                    studio = studio - (studio * 0.20);
                    apartmen = 68.70 * nights;
                    apartmen = apartmen - (apartmen * 0.10);

                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    studio = 76 * nights;
                    apartmen = 77 * nights;
                }
                else 
                {
                    studio = 76 * nights;
                    apartmen = 77 * nights;
                    apartmen = apartmen - (apartmen * 0.10);
                }
            }
            Console.WriteLine($"Apartment: {apartmen:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
