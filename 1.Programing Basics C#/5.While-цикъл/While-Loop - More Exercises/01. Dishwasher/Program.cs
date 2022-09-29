using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int dishesCleand = 0;
            int potsCleaned = 0;
            int detegrentUsed = 0;

            int count = 0;

            int detegrentAmount = 750 * int.Parse(n);

            string input = Console.ReadLine();

            while (input != "End")
            {
                int add = int.Parse(input);
                count++;

                if (count % 3 == 0)
                {
                    potsCleaned += add;
                    detegrentUsed += add * 15;
                }
                else
                {
                    dishesCleand += add;

                    detegrentUsed += add * 5;
                }

                if (detegrentAmount <= detegrentUsed)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            int left = detegrentAmount - detegrentUsed;

            if (left >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesCleand} dishes and {potsCleaned} pots were washed.");
                Console.WriteLine($"Leftover detergent {left} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(left)} ml. more necessary!");
            }
            
        }
    }
}

