using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> PlayerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> PlayerTwo = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            while (true)
            {
                if (PlayerOne.Count == 0 || PlayerTwo.Count== 0)
                {
                    if (PlayerOne.Count != 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {PlayerOne.Sum()}");
                        break;
                    }
                    else if (PlayerTwo.Count != 0) 
                    {
                        Console.WriteLine($"Second player wins! Sum: {PlayerTwo.Sum()}");
                        break;
                    }
                }

                if (PlayerOne[0] > PlayerTwo[0])
                {
                    PlayerOne.Add(PlayerTwo[0]);
                    PlayerOne.Add(PlayerOne[0]);

                    PlayerTwo.Remove(PlayerTwo[0]);
                    PlayerOne.Remove(PlayerOne[0]);
                }
                else if (PlayerTwo[0] > PlayerOne[0])
                {
                    PlayerTwo.Add(PlayerOne[0]);
                    PlayerTwo.Add(PlayerTwo[0]);

                    PlayerOne.Remove(PlayerOne[0]);
                    PlayerTwo.Remove(PlayerTwo[0]);
                }
                else if (PlayerOne[0] == PlayerTwo[0])
                {
                    PlayerOne.Remove(PlayerOne[0]);
                    PlayerTwo.Remove(PlayerTwo[0]);
                }

            }
        }
    }
}
