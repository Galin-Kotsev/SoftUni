using System;

namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int start = int.Parse(Console.ReadLine());
          int end = int.Parse(Console.ReadLine());

          int sum = 0;

            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    for (int h = start; h <= end; h++)
                    {
                        for (int k = start; k <= end; k++)
                        {
                            sum = g + h;

                            if (i%2 == 0)
                            {
                                if (k%2 != 0)
                                {
                                    if (i > k)
                                    {
                                        if (sum%2 == 0)
                                        {
                                            Console.Write($"{i}{g}{h}{k} ");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (k % 2 == 0)
                                {
                                    if (i > k)
                                    {
                                        if (sum % 2 == 0)
                                        {
                                            Console.Write($"{i}{g}{h}{k} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
