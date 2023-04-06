using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            RaceName = raceName;
            NumberOfLaps = numberOfLaps;
            Pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get { return raceName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: {value}.");

                }
                raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Invalid lap numbers: {value}.");

                }
                numberOfLaps = value;
            }
        }

        public bool TookPlace  { get ; set ; } = false;

        public ICollection<IPilot> Pilots
        { get; set ; }

        public void AddPilot(IPilot pilot)
        {
           Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The {raceName } race has:");
            sb.AppendLine($"Participants: {pilots.Count}");
            sb.AppendLine($"Number of laps: {numberOfLaps}");
            if(TookPlace)
            {
                sb.AppendLine("Took place: Yes");
            }
            else 
            {
                sb.AppendLine("Took place: No");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
