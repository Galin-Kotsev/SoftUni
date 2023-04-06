using PlanetWars.Models.MilitaryUnits.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {
        private const int defaultEnduranceLevel = 1;
        private int enduranceLevel;

        public MilitaryUnit(double cost)
        {
            Cost = cost;
            EnduranceLevel = defaultEnduranceLevel;
        }

        public double Cost { get; private set; }

        public int EnduranceLevel
        {
            get { return enduranceLevel; }
            private set { enduranceLevel = value; }
        }

        public void IncreaseEndurance()
        {
            if (enduranceLevel < 20)
            {
                enduranceLevel++;
            }
            else if (enduranceLevel > 20) 
            {
                enduranceLevel = 20;
                throw new ArgumentException
                    ("Endurance level cannot exceed 20 power points.");
            }
        }
    }
}

