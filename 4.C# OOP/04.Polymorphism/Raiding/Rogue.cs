using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string name) 
            : base(name, power)
        {
            Power = power;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"Rogue - {Name} hit for {Power} damage");
        }
    }
}
