using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Player> PlayerPool = new List<Player>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("vs"))
                {
                    string[] inputs = input.Split(" ");
                    string player1Name = inputs[0];
                    string player2Name = inputs[2];

                    Player player1
                        = PlayerPool.FirstOrDefault(x => x.PlayerName == player1Name);

                    Player player2
                        = PlayerPool.FirstOrDefault(x => x.PlayerName == player2Name);

                    if (player1 != null && player2 != null)
                    {
                        bool haveSameSkill = false;

                        foreach (var position in player1.Positions)
                        {
                            foreach (var position2 in player2.Positions)
                            {
                                if (position.Key == position2.Key)
                                {
                                    haveSameSkill = true;
                                }
                            }
                        }

                        if (haveSameSkill)
                        {
                            if (player1.TotalSkillPoints > player2.TotalSkillPoints)
                            {
                                PlayerPool.Remove(player2);
                            }
                            else if (player1.TotalSkillPoints < player2.TotalSkillPoints)
                            {
                                PlayerPool.Remove(player1);
                            }
                        }
                    }
                }
                else
                {
                    string[] inputs = input.Split(" -> ");
                    string playerName = inputs[0];
                    string position = inputs[1];
                    int skillPoints = int.Parse(inputs[2]);

                    Player player
                        = PlayerPool.FirstOrDefault(x => x.PlayerName == playerName);

                    if (player == null)
                    {
                        PlayerPool.Add(new Player(playerName, position, skillPoints));
                    }
                    else
                    {
                        if (player.Positions.ContainsKey(position))
                        {
                            if (player.Positions[position] < skillPoints)
                            {
                                player.Positions[position] = skillPoints;
                            }
                        }
                        else
                        {
                            player.Positions.Add(position, skillPoints);
                        }
                    }
                }
            }

            foreach (var player in PlayerPool.OrderByDescending(x => x.TotalSkillPoints))
            {
                Console.WriteLine($"{player.PlayerName}: {player.TotalSkillPoints} skill");

                foreach (var position in player.Positions.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
public class Player
{
    public Player(string playerName, string position, int skillPoints)
    {
        PlayerName = playerName;
        Positions = new Dictionary<string, int>
        {
            { position, skillPoints }
        };
    }

    public string PlayerName { get; set; }
    public Dictionary<string, int> Positions { get; set; }
    public int TotalSkillPoints => SkillPointsCalc();

    public int SkillPointsCalc()
    {
        int sum = 0;

        foreach (var item in Positions)
        {
            sum += item.Value;
        }
        return sum;
    }
}
