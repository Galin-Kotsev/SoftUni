using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            

            int litres = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                

                if (litres + liters > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    continue;
                }
                litres += liters;
            }
            Console.WriteLine(litres);
        }
    }
}
