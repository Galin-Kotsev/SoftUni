using System;

namespace _06._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int originalNum = num;
            int factorialSum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                int currentFact = 1;
                for (int i = digit; i > 0; i--)
                {
                    currentFact *= i;
                }
                factorialSum += currentFact;
            }

            if (originalNum == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
