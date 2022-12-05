using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace _01._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#$^]{6,10})";
            Regex regex = new Regex(pattern);

            string[] input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length == 20)
                {
                    string leftTickedStr = ticket.Substring(0, 10);
                    string rightTickedStr = ticket.Substring(10, 10);
                    string leftTicked = string.Empty;
                    string rightTicked= string.Empty;

                    Match match = regex.Match(leftTickedStr);
                    if (match.Success)
                    {
                        leftTicked = match.Groups[1].Value;
                    }

                    Match match2 = regex.Match(rightTickedStr);
                    if (match2.Success)
                    {
                        rightTicked = match2.Groups[1].Value;
                    }

                    if (leftTicked.Length >=6 && rightTicked.Length >= 6 && (rightTicked.Contains(leftTicked) || leftTicked.Contains(rightTicked)))
                    {
                        if (leftTicked.Length + rightTicked.Length == 20)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {rightTicked.Length}{rightTicked.First()} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {rightTicked.Length}{rightTicked.First()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}

