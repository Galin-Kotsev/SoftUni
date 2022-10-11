using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int neo = int.Parse(Console.ReadLine());

            PrintMatriX(neo);
        }

        private static void PrintMatriX(int neo)
        {
            for (int i = 0; i < neo; i++)
            {
                for (int k = 1; k < neo; k++)
                {
                    Console.Write(neo + " ");
                }

                Console.WriteLine(neo);
            }
        }
    }
}
