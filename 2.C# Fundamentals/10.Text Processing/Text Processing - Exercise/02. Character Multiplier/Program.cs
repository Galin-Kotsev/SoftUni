using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            int totalSum = 0;

            string line1 = input[0];
            string line2 = input[1];


            if (line1.Length < line2.Length)
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    totalSum += line1[i] * line2[i];
                }

                for (int i = line1.Length; i < line2.Length; i++)
                {
                    totalSum += line2[i];
                }

            }
            else
            {
                for (int i = 0; i < line2.Length; i++)
                {

                    totalSum += line1[i] * line2[i];
                }

                for (int i = line2.Length; i < line1.Length; i++)
                {
                    totalSum += line1[i];
                }
            }


            Console.WriteLine(totalSum);
        }
    }
}
