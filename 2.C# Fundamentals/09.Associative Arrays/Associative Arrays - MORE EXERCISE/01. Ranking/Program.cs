using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestList = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contest")
            {
                string[] inputs = input.Split(":");

                contestList.Add(inputs[0], inputs[1]);
                
                input = Console.ReadLine();
            }

            List<Contests> contests = new List<Contests>();  

            string input2 = Console.ReadLine();

            while (input2 != "end of submissions")
            {
                string[] inputs = input2.Split("=>");
                string contest = inputs[0];
                string password = inputs[1];
                string userName = inputs[2];
                int points = int.Parse(inputs[3]);

                if (contestList.ContainsKey(contest))
                {
                    if (password == contestList[contest])
                    {
                        if (contests.Any(x => x.Contest == contest))
                        {

                        }
                        
                    }
                }





                input2 = Console.ReadLine();
            }
        }
    }
}
public class Contests
{
    public Contests(string contest, string password, string username, int points)
    {
        Contest = contest;
        Password = password;
        Username = username;
        Points = points;
    }
    
    public string Contest { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public int Points { get; set; }

}


// to be continued