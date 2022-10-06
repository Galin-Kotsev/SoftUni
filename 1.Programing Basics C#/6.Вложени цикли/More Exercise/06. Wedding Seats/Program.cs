using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());

            int totalSeats = 0;

            for (int i = 'A'; i <= sector; i++)
            {
                row++;

                for (int g = 1; g < row; g++)
                {
                    if (g % 2 == 0)
                    {
                        for (int h = 'a'; h < seat+2 + 97; h++)
                        {
                            Console.WriteLine($"{(char)i}{g}{(char)h}");
                            totalSeats++;
                        }
                    }
                    else
                    {
                        for (int h = 'a' ; h < seat + 97; h++)
                        {
                            Console.WriteLine($"{(char)i}{g}{(char)h}");
                            totalSeats++;
                        }
                    }
                    
                }
            }
            Console.WriteLine(totalSeats);
        }
    }
}
