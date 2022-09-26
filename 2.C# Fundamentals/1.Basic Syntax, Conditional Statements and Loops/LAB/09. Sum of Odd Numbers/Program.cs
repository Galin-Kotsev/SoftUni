using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine(i);
                sum += i;
                i = i + 1;
               
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

