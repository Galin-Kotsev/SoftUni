﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name, power)
        {
            Power = power;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"Warrior - {Name} hit for {Power} damage");
        }
    }
}