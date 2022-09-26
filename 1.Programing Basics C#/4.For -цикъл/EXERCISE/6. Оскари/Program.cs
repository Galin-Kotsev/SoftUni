using System;

namespace _6._Оскари
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string vote = Console.ReadLine();
                double bonusPoints = double.Parse(Console.ReadLine());
                int votePoints = vote.Length;
                academyPoints += (votePoints * bonusPoints) / 2;

                if (academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyPoints:f1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actor} you need {1250.5 - academyPoints:f1} more!");


        }

    }
}
