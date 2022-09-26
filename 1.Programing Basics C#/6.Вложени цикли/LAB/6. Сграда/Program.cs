using System;

namespace _6._Сграда
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int a = floor; a >= 1; a--)
            {
                for (int b = 0; b < rooms; b++)
                {
                    if (a %2 == 0 && a < floor)
                    {
                        Console.Write($"O{a}{b} ");
                    }
                    else if (a == floor)
                    {
                        Console.Write($"L{a}{b} ");
                    }
                    else
                    {
                        Console.Write($"A{a}{b} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
