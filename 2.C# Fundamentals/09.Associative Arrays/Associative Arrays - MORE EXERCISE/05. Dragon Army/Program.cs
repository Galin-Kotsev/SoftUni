using System;
using System.Collections.Generic;
using System.Xml;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Dragon> dragons = new List<Dragon>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string type = inputs[0];
                string name = inputs[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (inputs[2] == "null")
                {
                    damage = 0;
                }
                else
                {
                    damage = int.Parse(inputs[2]);
                }

                if (inputs[3] == "null")
                {
                    health = 0;
                }
                else
                {
                    health = int.Parse(inputs[3]);
                }

                if (inputs[4] == "null")
                {
                    armor = 0;
                }
                else
                {
                    armor = int.Parse(inputs[4]);
                }




            }
           
        }
    }
}
public class Dragon
{
    public Dragon(string type, string name, int damage, int health, int armor)
    {
        Name = name;
        Type = type;
        Damage = damage;
        Health = health;
        Armor = armor;
    }

    public string Name { get; set; } 
    public string Type { get; set; }
    public int Damage { get; set; } = 0;        
    public int Health { get; set; } = 0;
    public int Armor { get; set; } = 0;
}
