using System;

namespace _2._Вело_състезание
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double totalRacers = 0;
            totalRacers = juniors + seniors;
            double expences = 0;

            if (track == "trail")
            {
                double sum = juniors * 5.5 + seniors * 7;
                expences = sum - (sum * 0.05);
            }
            else if (track == "cross-country")
            {
                double sum = juniors * 8 + seniors * 9.50;
                if (totalRacers >= 50)
                {
                    sum -= (sum * 0.25);
                }
                expences = sum - (sum * 0.05);

            }
            else if (track == "downhill")
            {
                double sum = juniors * 12.25 + seniors * 13.75;
               expences = sum - (sum * 0.05);
            }
            else if (track == "road")
            {
                double sum = juniors * 20 + seniors * 21.50;
                expences = sum - (sum * 0.05);
            }

        Console.WriteLine($"{expences:f2}");
        }
    }
}
