using System;

namespace _03._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;   

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int g = 1; g <= 9; g++)
                    {
                        for (int h = 1; h <= 9; h++)
                        {
                            sum1 = i + k;
                            sum2 = g + h;

                            if (sum1 == sum2)
                            {
                                if (n%sum1 == 0)
                                {
                                    Console.Write($"{i}{k}{g}{h} ");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
