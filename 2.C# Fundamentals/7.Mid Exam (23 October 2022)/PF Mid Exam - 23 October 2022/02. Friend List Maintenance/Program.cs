using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(", ")
                .ToList();

            int blackListed = 0;
            int lostNames = 0;

            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] inputs = input.Split(" ");
                string command = inputs[0];
                string name = inputs[1];


                if (command == "Blacklist")
                {
                    if (friends.Contains(name))
                    {
                        blackListed++;
                        Console.WriteLine($"{name} was blacklisted.");

                        friends[friends.IndexOf(name)] = "Blacklisted";
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(name);

                    if (index >= 0 && index < friends.Count)
                    {
                        if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                        {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                            lostNames++;
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Change")
                {
                    string newName = inputs[2];  

                    int index = int.Parse(name);

                    if (index >= 0 && index < friends.Count)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {newName}.");

                        friends.Insert(index, newName);
                        friends.RemoveAt(index + 1);

                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blackListed}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
    

