using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private PlanetRepository planets;

        public Controller()
        {
            planets = new PlanetRepository();
        }

        public string AddUnit(string unitTypeName, string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException
                    ($"Planet {planetName} does not exist!");
            }


            MilitaryUnit unit;

            if (unitTypeName == "SpaceForces")
            {
                unit = new SpaceForces();
            }
            else if (unitTypeName == "AnonymousImpactUnit")
            {
                unit = new AnonymousImpactUnit();
            }
            else if (unitTypeName == "StormTroopers")
            {
                unit = new StormTroopers();
            }
            else
            {
                throw new InvalidOperationException($"Planet {planetName} does not exist!");
            }

            if (planet.Army.FirstOrDefault(x => x.GetType().Name == unitTypeName) != null)
            {
                throw new InvalidOperationException
                    ($"{unitTypeName} already added to the Army of {planetName}!");
            }
            else
            {
                planet.Spend(unit.Cost);

                planet.AddUnit(unit);

                return $"{unitTypeName} added successfully to the Army of {planetName}!";

            }

        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException
                    ($"Planet {planetName} does not exist!");
            }

            Weapon weapon;

            if (weaponTypeName == "BioChemicalWeapon")
            {
                weapon = new BioChemicalWeapon(destructionLevel);
            }
            else if (weaponTypeName == "NuclearWeapon")
            {
                weapon = new NuclearWeapon(destructionLevel);
            }
            else if (weaponTypeName == "SpaceMissiles")
            {
                weapon = new SpaceMissiles(destructionLevel);
            }
            else
            {
                throw new InvalidOperationException
                    ($"{weaponTypeName} still not available!");
            }

            if (planet.Weapons.FirstOrDefault(x => x.GetType().Name == weaponTypeName) != null)
            {
                throw new InvalidOperationException
                    ($"{weaponTypeName} already added to the Weapons of { planetName}!");
            }
            else
            {
                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);
                return $"{planetName} purchased {weaponTypeName}!";
            }
        }

        public string CreatePlanet(string name, double budget)
        {
            Planet planet = new Planet(name, budget);

            if (planets.FindByName(name) != null)
            {
                return $"Planet {planet.Name} is already added!";
            }
            else
            {
                planets.AddItem(planet);
                return $"Successfully added Planet: {planet.Name}";
            }
        }

        public string ForcesReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***UNIVERSE PLANET MILITARY REPORT***");

           foreach (Planet planet in planets.Models) 
            {
               sb.AppendLine(planet.PlanetInfo().TrimEnd());
            }

           return sb.ToString().TrimEnd();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet planet = planets.FindByName(planetOne);
            IPlanet planet2 = planets.FindByName(planetTwo);

            if (planet.MilitaryPower == planet2.MilitaryPower)
            {
                bool planet1hasBomb = false;
                bool planet2hasBomb = false;

                foreach (var item in planet.Weapons)
                {
                    if (item.GetType().Name == "NuclearWeapon")
                    {
                        planet1hasBomb = true;  
                    }
                }

                foreach (var item in planet2.Weapons)
                {
                    if (item.GetType().Name == "NuclearWeapon")
                    {
                        planet2hasBomb = true;
                    }
                }

                if (planet1hasBomb)
                {
                    planet.Spend(planet.Budget / 2);
                    planet.Profit(planet2.Budget / 2);
                    planet.Profit(planet2.Weapons.Sum(x => x.Price));
                    planet.Profit(planet2.Army.Sum(x => x.Cost));
                    planets.RemoveItem(planetTwo);
                    return $"{planet.Name} destructed {planet2.Name}!";

                }
                else if (planet2hasBomb)
                {
                    planet2.Spend(planet2.Budget / 2);
                    planet2.Profit(planet.Budget / 2);
                    planet2.Profit(planet.Weapons.Sum(x => x.Price));
                    planet2.Profit(planet.Army.Sum(x => x.Cost));
                    planets.RemoveItem(planetOne);
                    return $"{planet2.Name} destructed {planet.Name}!";
                }
                else
                {
                    planet2.Spend(planet2.Budget / 2);
                    planet.Spend(planet.Budget / 2);
                    return 
                 $"The only winners from the war are the ones who supply the bullets and the bandages!";
                }
            }
            else if (planet.MilitaryPower > planet2.MilitaryPower)
            {
                planet.Spend(planet.Budget / 2);
                planet.Profit(planet2.Budget / 2);
                planet.Profit(planet2.Weapons.Sum(x => x.Price));
                planet.Profit(planet2.Army.Sum(x => x.Cost));
                planets.RemoveItem(planetTwo);
                return $"{planet.Name} destructed {planet2.Name}!";

            }
            else if (planet2.MilitaryPower > planet.MilitaryPower)
            {
                planet2.Spend(planet2.Budget / 2);
                planet2.Profit(planet.Budget / 2);
                planet2.Profit(planet.Weapons.Sum(x => x.Price));
                planet2.Profit(planet.Army.Sum(x => x.Cost));
                planets.RemoveItem(planetOne);
                return $"{planet2.Name} destructed {planet.Name}!";
            }
            else
            {
                planet2.Spend(planet2.Budget / 2);
                planet.Spend(planet.Budget / 2);
                return
             $"The only winners from the war are the ones who supply the bullets and the bandages!";
            }
        }

        public string SpecializeForces(string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException
                    ($"Planet {planetName} does not exist!");
            }

            if (!planet.Army.Any())
            {
                throw new InvalidOperationException
                    ($"No units available for upgrade!");
            }

            planet.Spend(1.25);
            planet.TrainArmy();
            return $"{planet.Name} has upgraded its forces!";

        }
    }
}
