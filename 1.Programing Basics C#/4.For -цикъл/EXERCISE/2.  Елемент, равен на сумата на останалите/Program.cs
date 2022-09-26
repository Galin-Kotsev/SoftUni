using System;

namespace _2.__Елемент__равен_на_сумата_на_останалите
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int add = int.Parse(Console.ReadLine());
                sum += add;

                if (add>= maxNum)
                {
                    maxNum = add;

                }

            }
            int sumMax = sum - maxNum;
            if (maxNum == sumMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum-maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-sumMax)}");
            }

        }
    }
}
