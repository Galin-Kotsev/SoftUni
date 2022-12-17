using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contests> contests = new List<Contests>();

            Dictionary<string, int> users = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[]inputs = input.Split(" -> ");
                string userName = inputs[0];
                string contest = inputs[1];
                int points = int.Parse(inputs[2]);

                

                if (!contests.Any(x => x.Name == contest))
                {
                    contests.Add(new Contests(contest));
                }

                Contests selectedContest = contests.First(x => x.Name == contest);

                if (!selectedContest.User.ContainsKey(userName))
                {
                    selectedContest.User.Add(userName, points);
                }
                else if (selectedContest.User[userName] < points)
                {
                    selectedContest.User[userName] = points;
                  
                }

                input = Console.ReadLine();
            }

            foreach (var contest in contests)
            {
                foreach (var user in contest.User)
                {
                    if (!users.ContainsKey(user.Key))
                    {
                        users.Add(user.Key, user.Value);
                    }
                    else
                    {
                        users[user.Key] += user.Value;
                    }
                }
            }

            foreach (var item in contests)
            {
                Console.WriteLine($"{item.Name}: {item.User.Count()} participants");

                int counter = 1;

                foreach (var (Key, Value) in item.User.OrderByDescending((x => x.Value)).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {Key} <::> {Value}");
                    counter++;
                }
            }

            int count = 1;

            Console.WriteLine($"Individual standings:");
            foreach (var (User, Points) in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {User} -> {Points}");

                count++;
            }
        }
    }
}
class Contests
{
    public Contests(string contest)   
    {
        Name = contest;
        User = new Dictionary<string, int>();
    }

    public string Name { get; set; }
    public Dictionary<string, int> User { get; set; }

}


