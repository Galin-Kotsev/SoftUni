using System;
using System.Linq;

namespace _04._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int Sum = 0;

            for (int i = a; i <= b; i++)
            {
                Console.Write($"{i} ");
                Sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {Sum}");

            
        }
    }
}
