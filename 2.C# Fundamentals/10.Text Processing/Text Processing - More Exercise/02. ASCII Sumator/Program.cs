using System;

namespace _02._ASCII_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charecter1 = char.Parse(Console.ReadLine());
            char charecter2 = char.Parse(Console.ReadLine());
            string randomText = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < randomText.Length; i++)
            {
                if (randomText[i] > charecter1 && randomText[i] < charecter2)
                {
                    sum += randomText[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
