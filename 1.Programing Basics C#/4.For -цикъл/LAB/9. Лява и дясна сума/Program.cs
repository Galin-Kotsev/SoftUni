﻿using System;

namespace _9._Лява_и_дясна_сума
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
                leftSum += x;
            }

                
            for (int i = 0; i < n; i++)
            {
                int z = int.Parse(Console.ReadLine());
                rightSum += z;
            }

            if (leftSum == rightSum)
            {
                
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                
                Console.WriteLine($"No, diff = {Math.Abs(rightSum-leftSum)}");
            }
               
                


        }
    }
}
