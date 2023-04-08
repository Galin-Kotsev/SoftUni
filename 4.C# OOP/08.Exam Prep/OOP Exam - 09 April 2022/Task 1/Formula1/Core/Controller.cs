using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot = pilotRepository.FindByName(pilotName);

            if (pilot == null || pilot.CanRace)
            {
                throw new InvalidOperationException
                    ($"Pilot {pilotName} does not exist or has a car.");
            }

            IFormulaOneCar pilotCar = carRepository.FindByName(carModel);

            if (pilotCar == null)
            {
                throw new NullReferenceException
                    ($"Car {carModel} does not exist.");
            }

            pilot.AddCar(pilotCar);
            carRepository.Remove(pilotCar);

            return
            $"Pilot {pilotName} will drive a {pilotCar.GetType().Name} {carModel} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IPilot pilot = pilotRepository.FindByName(pilotFullName);
            IRace race = raceRepository.FindByName(raceName);

            IPilot pilotInRace
                = race.Pilots.FirstOrDefault(x => x.FullName == pilotFullName);

            if (race == null)
            {
                throw new NullReferenceException
                    ($"Race {raceName} does not exist.");
            }

            if (pilot == null || pilot.CanRace == false || pilotInRace != null)
            {
                throw new InvalidOperationException
                    ($"Can not add pilot {pilotFullName} to the race.");
            }


            race.AddPilot(pilot);
            return
            $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            IFormulaOneCar car;

            if (type == "Ferrari")
            {
                if (carRepository.FindByName(model) == null)
                {
                    car = new Ferrari(model, horsepower, engineDisplacement);
                    carRepository.Add(car);
                    return $"Car {type}, model {model} is created.";
                }
                else
                {
                    throw new InvalidOperationException
                        ($"Formula one car {model} is already created.");
                }
            }
            else if (type == "Williams")
            {
                if (carRepository.FindByName(model) == null)
                {
                    car = new Williams(model, horsepower, engineDisplacement);
                    carRepository.Add(car);
                    return $"Car {type}, model {model} is created.";
                }
                else
                {
                    throw new InvalidOperationException
                        ($"Formula one car {model} is already created.");
                }
            }
            else
            {
                throw new InvalidOperationException
                    ($"Formula one car type {type} is not valid.");
            }
        }

        public string CreatePilot(string fullName)
        {
            Pilot pilot = new Pilot(fullName);

            if (pilotRepository.FindByName(fullName) == null)
            {
                pilotRepository.Add(pilot);
                return $"Pilot {fullName} is created.";
            }
            else
            {
                throw new InvalidOperationException
                    ($"Pilot {fullName} is already created.");
            }
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            Race race = new Race(raceName, numberOfLaps);

            if (raceRepository.FindByName(raceName) == null)
            {
                raceRepository.Add(race);
                return "Race { race name } is created.";
            }
            else
            {
                throw new InvalidOperationException
                    ($"Race {raceName} is already created.");
            }
        }

        public string PilotReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pilot in pilotRepository.Models.OrderByDescending(x => x.NumberOfWins))
            {
                sb.AppendLine($"Pilot {pilot.FullName} has {pilot.NumberOfWins} wins.");

            }
            return sb.ToString();
        }

        public string RaceReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var race in raceRepository.Models)
            {
                if (race.TookPlace)
                {
                    sb.AppendLine(race.RaceInfo());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);

            bool raceExist = false;
            bool racePilotsMoreThen3 = false;
            bool noRace = false;


            if (race == null)
            {
                throw new NullReferenceException
                    ($"Race {raceName} does not exist.");
            }
            else
            {
                raceExist = true;
            }

            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException
                    ($"Race {raceName} cannot start with less than three participants.");
            }
            else
            {
                racePilotsMoreThen3 = true;
            }

            if (race.TookPlace)
            {
                throw new InvalidOperationException
                    ($"Can not execute race {raceName}.");
            }
            else
            {
                noRace = true;
            }

            race.TookPlace = true;
            var orderedPilots
                = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).ToArray();
            orderedPilots[0].WinRace();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pilot {orderedPilots[0]} wins the {raceName} race.");
            sb.AppendLine($"Pilot {orderedPilots[1]} is second in the {raceName} race.");
            sb.AppendLine($"Pilot {orderedPilots[2]} is third in the {raceName} race.");

            return sb.ToString().TrimEnd();
        }
    }
}
