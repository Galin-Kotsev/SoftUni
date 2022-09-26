using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int days = 0;

            int harvest = n;
            int harvest2 = 0;

            while (true)
            {
                harvest2 += harvest;
                harvest -= 10;

                days++;

                if (harvest2 >= 26)
                {
                    harvest2 -= 26;
                }


                if (harvest <= 100)
                {
                    harvest2 -= 26;
                    break;

                }
            }
            Console.WriteLine(days);
            Console.WriteLine(harvest2);
        }
    }
}
