using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());

            int combinationsSuccess = 0;
            int combinationFails = 0;
            int error = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    combinationsSuccess++;
                    combinationFails++;

                    if (i + k == magicN)
                    {
                        Console.WriteLine($"Combination N:{combinationsSuccess} ({i} + {k} = {magicN})");
                        error++;
                        return;
                    }
                }
            }

            if (error == 0)
            {
                Console.WriteLine($"{combinationFails} combinations - neither equals {magicN}");
            }
        }
    }
}
