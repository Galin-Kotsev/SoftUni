using System;

namespace _10.SHIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    leftSum += x;
                }
                else
                {
                    rightSum += x;
                }
            }

            if (leftSum == rightSum)
            {

                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {leftSum}");
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(rightSum - leftSum)}");
            }

        }
    }
}



