﻿using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double  sum = 0;

            string model = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double result = Math.PI * Math.Pow(radius,2) * height;

                if (result >= sum)
                {
                    sum = result;
                    model = type;
                }

            }


            Console.WriteLine(model);
        }
    }
}
