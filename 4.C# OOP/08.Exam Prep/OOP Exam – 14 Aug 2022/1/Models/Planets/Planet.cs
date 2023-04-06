using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private UnitRepository units;
        private WeaponRepository weapons;
        private string name;
        private double budget;

        public Planet(string name, double budget)
        {
            Name = name;
            Budget = budget;
            units = new UnitRepository();
            weapons = new WeaponRepository();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                         ("Planet name cannot be null or empty.");
                }

                name = value;
            }
        }

        public double Budget
        {
            get { return budget; }
            private set
            {
                if (budget < 0)
                {
                    throw new ArgumentException
                            ("Budget's amount cannot be negative.");
                }

                budget = value;
            }
        }

        public double MilitaryPower
        {
            get
            {
                return CalculateMilitaryPower();
            }
            private set
            {

            }
        }

        public double CalculateMilitaryPower()
        {
            double amounnt
                = units.Models.Sum(x => x.EnduranceLevel) + weapons.Models.Sum(x => x.DestructionLevel);

            if (weapons.FindByName("AnonymousImpactUnit") != null)
            {
                amounnt = amounnt * 1.30;
            }

            if (weapons.FindByName("NuclearWeapon") != null)
            {
                amounnt = amounnt * 1.45;
            }

            return Math.Round(amounnt, 3);
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => weapons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
            units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.AddItem(weapon);
        }

        public string PlanetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            if (units.Models.Any())
            {
                sb.AppendLine($"--Forces: {string.Join(", ", Army.Select(x => x.GetType().Name))}");
            }
            else
            {
                sb.AppendLine($"--Forces: No units");
            }
            if (weapons.Models.Any())
            {
                sb.AppendLine($"--Combat equipment: {string.Join(", ", Weapons.Select(x => x.GetType().Name))}");
            }
            else
            {
                sb.AppendLine($"--Combat equipment: No weapons");
            }
            sb.AppendLine($"--Military Power: {MilitaryPower}");

            return sb.ToString();
        }

        public void Profit(double amount)
        {
            Budget += amount;
        }

        public void Spend(double amount)
        {
            if (Budget - amount < 0)
            {
                throw new InvalidOperationException("Budget too low!");
            }
            else
            {
                Budget -= amount;
            }
        }

        public void TrainArmy()
        {
            foreach (var unit in units.Models)
            {
                unit.IncreaseEndurance();
            }
        }
    }
}


