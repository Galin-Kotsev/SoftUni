using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers 
                = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string sentance = Console.ReadLine();

            string text = string.Empty;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;

                string numbersSum = numbers[0].ToString();

                for (int k = 0; k < numbersSum.Length; k++)
                {
                    sum += int.Parse(numbersSum[k].ToString());
                }

                if (sum > sentance.Length - 1)
                {
                    sum = sum - sentance.Length;
                }

                text += sentance[sum];
                sentance = sentance.Remove(sum, 1);
                numbers.RemoveAt(0);
                i--;
                sum = 0;
            }
                Console.WriteLine(text);
        }
    }
}
