using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            var contestsList
                = new List<Contest>();
            var scoreList 
                = new Dictionary<string, int>();

            while 
            ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputs = input.Split(":");
                string contest = inputs[0];
                string passowrd = inputs[1];

                Contest contests
                    = contestsList
                    .FirstOrDefault(x => x.Contests == contest);

                if
                (contests == null)
                {
                    contestsList.Add(new Contest(contest, passowrd));
                }
            }

            while 
            ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inputs = input.Split("=>");
                string contest = inputs[0];
                string passowrd = inputs[1];
                string user = inputs[2];
                int points = int.Parse(inputs[3]);

                Contest checkContest 
                    = contestsList
                    .FirstOrDefault(x => x.Contests == contest && x.Password == passowrd);

                if 
                (checkContest != null)
                {
                    Participant participant 
                        = checkContest.Participants
                        .FirstOrDefault(x => x.Username == user);

                    if 
                    (participant != null)
                    {
                        if (points > participant.Points)
                        {
                            participant.Points = points;
                        }
                    }
                    else
                    {
                        checkContest.Participants.Add(new Participant(user, points));
                    }
                }
            }

            foreach (var contest in contestsList)
            {
                foreach (var participant in contest.Participants)
                {
                    if (!scoreList.ContainsKey(participant.Username))
                    {
                        scoreList.Add(participant.Username, participant.Points);    
                    }
                    else
                    {
                        scoreList[participant.Username] += participant.Points;
                    }
                }
            }

            scoreList 
                = scoreList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {scoreList.First().Key} with total {scoreList.First().Value} points.");
            Console.WriteLine("Ranking:");

            foreach (var participant in scoreList.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine(participant.Key);
                Dictionary<string, int> score = new Dictionary<string, int>();
                foreach (var conts in contestsList)
                {
                    if (conts.Participants.FirstOrDefault(x => x.Username == participant.Key) != null)
                    {
                        score.Add(conts.Contests, conts.Participants.FirstOrDefault(x => x.Username == participant.Key).Points);
                    }
                }

                score 
                    = score.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in score)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }
    }  
}
public class Contest
{
    public Contest(string contest, string password)
    {
        Contests = contest;
        Password = password;
        Participants = new List<Participant>();
    }
    public string Contests { get; set; }
    public string Password { get; set; }
    public List<Participant> Participants { get; set; }
}
public class Participant
{
    public Participant(string username, int points)
    {
        Username = username;
        Points = points;
    }
    public string Username { get; set; }
    public int Points { get; set; }
}


