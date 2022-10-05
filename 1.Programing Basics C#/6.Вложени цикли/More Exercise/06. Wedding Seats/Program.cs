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

            for (int i = 1; i <= sector; i++)
            {
                for (int g = 1; g <= row; g++)
                {
                    if (row % 2 == 0)
                    {
                        for (int h = 1; h <= seat+2; h++)
                        {
                            Console.WriteLine($"{(char)i}{g}{(char)h}");
                        }
                    }
                    else
                    {
                        for (int h = 1; h <= seat; h++)
                        {
                            Console.WriteLine($"{(char)i}{g}{(Char)h}");
                        }
                    }
                    
                }
            }
        }
    }
}
