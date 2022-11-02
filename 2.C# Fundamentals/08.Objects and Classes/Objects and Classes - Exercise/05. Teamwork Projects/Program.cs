using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split("-");
                string creator = inputs[0];
                string teamName = inputs[1];

                if( teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    if (teams.Any(x => x.TeamName == teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                        teams.Add(new Team(teamName, creator));
                    }
                }
            }

            string input2 = Console.ReadLine();

            while (input2 != "end of assignment")
            {
                string[] inputs = input2.Split("->");
                string members = inputs[0];
                string teamName = inputs[1];

                if (!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(members) || teams.Any(x => x.Creator == members)))
                {
                    Console.WriteLine($"Member {members} cannot join team {teamName}!");
                }
                else
                {
                    Team team = teams.Find(x => x.TeamName == teamName);
                    team.Members.Add(members);
                }

                input2 = Console.ReadLine();
            }

            List<Team> disbaded = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();
            teams.RemoveAll(x => x.Members.Count == 0);

            foreach (var Team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                Console.WriteLine(Team.TeamName);
                Console.WriteLine($"- {Team.Creator}");
                foreach (var team in Team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {team}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var Team in disbaded)
            {
                Console.WriteLine(Team.TeamName);
            }
        }
    }
}

public class Team
{
    public Team(string teamName, string creator)
    {
        TeamName = teamName;
        Creator = creator;
        Members = new List<string>();
    }

    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}
