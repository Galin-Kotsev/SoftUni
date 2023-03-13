namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> rapidGroup = new();
            int heroPowerSum = 0;

            while (rapidGroup.Count != n)
            {
                HeroAdder(rapidGroup);
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in rapidGroup)
            {
                hero.CastAbility();
                heroPowerSum += hero.Power;
            }

            if (bossPower <= heroPowerSum)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static void HeroAdder(List<BaseHero> rapidGroup)
        {
            string namePlayer = Console.ReadLine();
            string name = Console.ReadLine();

            if (name == "Warrior")
            {
                rapidGroup.Add(new Warrior(namePlayer));
            }
            else if (name == "Paladin")
            {
                rapidGroup.Add(new Paladin(namePlayer));
            }
            else if (name == "Druid")
            {
                rapidGroup.Add(new Druid(namePlayer));
            }
            else if (name == "Rogue")
            {
                rapidGroup.Add(new Rogue(namePlayer));
            }
            else
            {
                Console.WriteLine("Invalid hero!");
            }
        }
    }
}