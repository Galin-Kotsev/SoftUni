using Formula1.Models.Contracts;
using System;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            FullName = fullName;
        }

        public string FullName
        {
            get { return fullName; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 5) 
                {
                    throw new ArgumentException($"Invalid pilot name: {value}.");
                }

                fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get { return car; }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException($"Pilot car can not be null.");
                }

                car = value;
            }
        }

        public int NumberOfWins
        {   
            get; 
            private set; 
        }

        public bool CanRace { get; set; } = false;

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }

        public override string ToString()
        {
            return ($"Pilot {fullName} has {NumberOfWins} wins.");
        }

    }
}

