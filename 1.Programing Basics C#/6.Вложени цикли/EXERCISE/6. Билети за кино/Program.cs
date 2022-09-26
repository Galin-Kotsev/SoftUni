using System;

namespace _6._Билети_за_кино
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double student = 0;
            double student2 = 0;
            double standard = 0;
            double standard2 = 0;
            double kid = 0;
            double kid2 = 0;
            double tickedSum = 0;

            while (movie != "Finish")
            {
                string movieName = movie;
                int seats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int ticketsSold = 0;
                while (ticketType != "End")
                {
                    ticketsSold++;
                    tickedSum++;
                    if (ticketType == "student")
                    {
                        student++;
                        student2++;

                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                        standard2++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                        kid2++;
                    }
                    if (ticketsSold == seats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                double sum = (kid + student + standard) / seats * 100;
                Console.WriteLine($"{movieName} - {sum:f2}% full.");
                kid = 0;
                standard = 0;
                student = 0;
                movie = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {tickedSum}");
            Console.WriteLine($"{student2 / tickedSum * 100:f2}% student tickets.");
            Console.WriteLine($"{standard2 / tickedSum * 100:f2}% standard tickets.");
            Console.WriteLine($"{kid2 / tickedSum * 100:f2}% kids tickets.");


        }
    }

}
