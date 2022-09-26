using System;

namespace _4._Сума_от_две_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int a = x; a <= y ; a++)
            {
                
                for (int b = x; b <= y; b++)
                {
                    int sum = a + b;
                    count++;
                    if (sum == n )
                    {
                        Console.WriteLine($"Combination N:{count} ({a} + {b} = {n})");
                        return;
                    }
                }
            }
             Console.WriteLine($"{count} combinations - neither equals {n}");
        }
    }
}
