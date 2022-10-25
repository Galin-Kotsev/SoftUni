using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= input; i++)
            {
                decimal a = decimal.Parse(Console.ReadLine());

                sum += a;
            }

            Console.WriteLine(sum);
        }
    }
}
