using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> charectar = Console.ReadLine()
                .Split("|")
                .ToList();

            int health = 100;
            int room = 0;
            int bitcoins = 0;
            bool alive = true;


            for (int i = 0; i < charectar.Count; i++)
            {
                room++;

                string[] input = charectar[i].Split(" ");

                string command = input[0];
                int integer = int.Parse(input[1]);

                if (command == "potion")
                {
                    if (health < 100)
                    {
                        if (health+integer > 100)
                        {
                            int hp = 100 - health;
                            health = 100;

                            Console.WriteLine($"You healed for {hp} hp.");
                            Console.WriteLine("Current health: 100 hp.");
                        }
                        else
                        {
                            health += integer;
                            Console.WriteLine($"You healed for {integer} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                    }
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {integer} bitcoins.");

                    bitcoins += integer;

                }
                else
                {
                    health -= integer;
                    string monster = command;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {room}");
                        
                        alive = false;
                        break;
                    }
                }
            }
            if (alive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");

            }

        }
    }
}
