using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name) 
            : base(name, power)
        {
            Power = power;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"Paladin - {Name} healed for {Power}");
        }
    }
}
