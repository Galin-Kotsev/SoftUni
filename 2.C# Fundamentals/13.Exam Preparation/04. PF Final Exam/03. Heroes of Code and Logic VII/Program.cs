using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroes
                 = new Dictionary<string, List<int>>();

            string input;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] inputs = input.Split(" ");
                string name = inputs[0];
                int hp = int.Parse(inputs[1]);
                int mp = int.Parse(inputs[2]);

                if (hp <= 100 && mp <= 200)
                {
                    heroes.Add(name, new List<int> { hp, mp });
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split(" - ");

                string action = inputs[0];
                string name = inputs[1];

                if (action == "CastSpell")
                {
                    int mpCost = int.Parse(inputs[2]);
                    string spell = inputs[3];

                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name][1] >= mpCost)
                        {
                            heroes[name][1] -= mpCost;

                            Console.WriteLine($"{name} has successfully cast {spell} and now has {heroes[name][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                        }
                    }
                }

                if (action == "TakeDamage")
                {
                    int damage = int.Parse(inputs[2]);
                    string attacker = inputs[3];

                    if (heroes.ContainsKey(name))
                    {
                        heroes[name][0] -= damage;

                        if (heroes[name][0] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            heroes.Remove(name);
                        }
                    }
                }

                if (action == "Recharge")
                {
                    int amount = int.Parse(inputs[2]);

                    if (heroes.ContainsKey(name))
                    {
                        int currentMana = heroes[name][1];

                        heroes[name][1] += amount;

                        if (heroes[name][1] > 200)
                        {
                            heroes[name][1] = 200;
                        }

                        Console.WriteLine($"{name} recharged for {heroes[name][1] - currentMana} MP!");
                        
                    }
                }

                if (action == "Heal")
                {
                    int amount = int.Parse(inputs[2]);

                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name][0] + amount > 100)
                        {
                            Console.WriteLine($"{name} healed for {(100 - heroes[name][0])} HP!");

                            heroes[name][0] = 100;  
                        }
                        else
                        {
                            heroes[name][0] += amount;

                            Console.WriteLine($"{name} healed for {amount} HP!");
                        }
                    }
                }
            }

            foreach (var (Key, Value) in heroes)
            {
                Console.WriteLine(Key);
                Console.WriteLine($"  HP: {Value[0]}");
                Console.WriteLine($"  MP: {Value[1]}");  
            }


            }
        }
    }

