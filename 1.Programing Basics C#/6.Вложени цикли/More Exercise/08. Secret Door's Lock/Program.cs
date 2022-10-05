using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int fews = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                for (int h = 1; h <= tens; h++)
                {
                    for (int g = 1; g <= fews; g++)
                    {
                        if (i%2 == 0)
                        {
                            if (h == 2 || h == 3 || h == 5 || h == 7)
                            {
                                if (g % 2 == 0)
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
}
