using System;

namespace _4._Четни_степени_на_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int power = 0; power <= n; power+=2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}
