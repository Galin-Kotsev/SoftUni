using Formula1.Models.Contracts;
using System;

namespace Formula1.Models
{
    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private string model;
        private int horsepower;
        private double engineDisplacement;

        protected FormulaOneCar(string model, int horsepower, double engineDisplacement)
        {
            Model = model;
            Horsepower = horsepower;
            EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get { return model; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 3)
                {
                    throw new ArgumentException($"Invalid car model: {model}.");
                }

                model = value;
            }
        }
        public int Horsepower
        {
            get { return horsepower; }

            private set
            {
                if (value < 900 && value > 1050)
                {
                    throw new ArgumentException($"Invalid car horsepower: {value}.");
                }

                horsepower = value;
            }
        }

        public double EngineDisplacement
        {
            get { return engineDisplacement; }

            private set
            {
                if (value < 1.6 && value > 2.0)
                {
                    throw new ArgumentException($"Invalid car engine displacement: {value}.");
                }

                engineDisplacement = value;
            }
        }

        public double RaceScoreCalculator(int laps)
           => engineDisplacement / horsepower * laps;
    }
}

