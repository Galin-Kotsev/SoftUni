﻿using System;

namespace _1._Oтлична_оценка
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50) 
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
