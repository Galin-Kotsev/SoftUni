using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            List<int> numbers = new List<int>();
            List<string> text = new List<string>();

            string hiddenMessage = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else if (char.IsLetter(input[i]))
                {
                    text.Add(input[i].ToString());
                }
                else
                {
                    text.Add(input[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++) 
            {
                if (i % 2 == 0)
                {
                    take.Add(int.Parse(numbers[i].ToString()));
                }
                else
                {
                    skip.Add(int.Parse(numbers[i].ToString()));
                }
            }

            int totalSkipped = 0;

            for (int i = 0 ; i < take.Count; i++)
            {
                int currTake = take[i];
                int currSkip = skip[i];

                hiddenMessage += string.Join("", text.Skip(totalSkipped).Take(currTake));

                totalSkipped += currSkip+currTake;
            }

            Console.WriteLine(hiddenMessage.ToString());
        }
    }
}
