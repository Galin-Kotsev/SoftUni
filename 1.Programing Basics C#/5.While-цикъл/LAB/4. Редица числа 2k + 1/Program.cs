﻿using System;

namespace _4._Редица_числа_2k___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            while (k<=n)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
