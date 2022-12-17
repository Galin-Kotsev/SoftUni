using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<DragonType> dragons = new List<DragonType>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string type = inputs[0];
                string name = inputs[1];
                double damage = 0;
                double health = 0;
                double armor = 0;

                if (inputs[2] != "null") damage = double.Parse(inputs[2]);

                if (inputs[3] != "null") health = double.Parse(inputs[3]);
                
                if (inputs[4] != "null") armor = double.Parse(inputs[4]);
                
                DragonType dragonType 
                    = dragons.FirstOrDefault(x => x.DragonStats == type);

                if (dragonType == null)
                {
                    dragons.Add(new DragonType(type));
                    dragonType = dragons.FirstOrDefault(x => x.DragonStats == type);
                }

                Dragon dragon
                    = dragonType.Dragons.FirstOrDefault(x => x.Name == name);

                if (dragon == null)
                {
                    dragonType.Dragons.Add(new Dragon(name,damage,health,armor));
                }
                else
                {
                    dragon.Armor = armor;
                    dragon.Damage = damage;
                    dragon.Health = health;
                }
            }

            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.DragonStats}::({dragonType.Dragons.Average(x => x.Damage):f2}/{dragonType.Dragons.Average(x => x.Health):f2}/{dragonType.Dragons.Average(x => x.Armor):f2})");

                foreach (var dragon in dragonType.Dragons.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
public class Dragon
{
    public Dragon(string name, double damage, double health, double armor)
    {
        Name = name;
        Damage = damage;
        Health = health;
        Armor = armor;
    }

    public string Name { get; set; }
    public double Damage { get; set; } 
    public double Health { get; set; } 
    public double Armor { get; set; } 
}

public class DragonType
{
    public DragonType(string type)
    {
        Dragons = new List<Dragon>();
        DragonStats = type;
    }

    public string DragonStats { get; set; }
    public List<Dragon> Dragons { get; set; }
}