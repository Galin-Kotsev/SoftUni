using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxSeats = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int k = 1; k <= women; k++)
                {
                    if (count >= maxSeats )
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"({i} <-> {k}) ");
                        count++;
                    }
                    
                   
                }
            }
        }
    }
}
