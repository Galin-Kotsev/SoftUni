using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int h = 1; h <= b; h++)
                {
                    for (int g = 1; g <= c; g++)
                    {
                        if (i%2==0 && g%2==0)
                        {
                            if (h == 2 || h == 3 || h == 5 || h == 7)
                            {
                                Console.WriteLine($"{i} {h} {g}");
                            }
                        }
                    }
                }
            }
        }
    }
}
