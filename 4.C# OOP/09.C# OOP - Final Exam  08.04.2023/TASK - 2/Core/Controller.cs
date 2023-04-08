using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private SupplementRepository supplements;
        private RobotRepository robotRepository;

        public Controller()
        {
            supplements = new SupplementRepository();
            robotRepository = new RobotRepository();
         }

        public string CreateRobot(string model, string typeName)
        {
            IRobot robot;
            if (typeName == "DomesticAssistant")
            {
                robot = new DomesticAssistant(model);
                robotRepository.AddNew(robot);
                return $"{typeName} {model} is created and added to the RobotRepository.";
            }
            else if (typeName == "IndustrialAssistant")
            {
                robot = new IndustrialAssistant(model);
                robotRepository.AddNew(robot);
                return $"{typeName} {model} is created and added to the RobotRepository.";
            }
            else 
            {
                return $"Robot type {typeName} cannot be created.";
            }
        }

        public string CreateSupplement(string typeName)
        {
            ISupplement supplement;

            if (typeName == "SpecializedArm")
            {
                supplement = new SpecializedArm();

                supplements.AddNew(supplement);

                return $"{ typeName} is created and added to the SupplementRepository.";
            }
            else if (typeName == "LaserRadar")
            {
                supplement = new LaserRadar();

                supplements.AddNew(supplement);

                return $"{typeName} is created and added to the SupplementRepository.";
            }
            else
            {
                return $"{typeName} is not compatible with our robots.";
            }
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            var robotsModels = robotRepository.Models();
            var robots = robotsModels.Where(x => x.InterfaceStandards.Contains(intefaceStandard)).OrderByDescending(x => x.BatteryLevel);
            if (!robots.Any())
            {
                return $"Unable to perform service, {intefaceStandard} not supported!";
            }
            int counter = 0;
            int sum = robots.Sum(x => x.BatteryLevel);
            if (sum < totalPowerNeeded)
            {
                return $"{serviceName} cannot be executed! {totalPowerNeeded - sum} more power needed.";
            }
            else
            {
                
                foreach (var robot in robots)
                {
                    if (robot.BatteryLevel >= totalPowerNeeded)
                    {
                        robot.ExecuteService(totalPowerNeeded);
                        counter++;
                    }
                    else
                    {
                        totalPowerNeeded -= robot.BatteryLevel;
                        robot.ExecuteService(robot.BatteryLevel);
                        counter++;
                    }
                }
            }

            return $"{serviceName} is performed successfully with {counter} robots.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var robot in robotRepository.Models().OrderByDescending(x => x.BatteryLevel).ThenBy(x => x.BatteryCapacity))
            {
                sb.AppendLine(robot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            int fedCount = 0;
           var robots = robotRepository.Models().Where(x => x.BatteryLevel < x.BatteryCapacity / 2);
            foreach (var robot in robots)
            {
                fedCount++;
                robot.Eating(minutes);
            }

            return $"Robots fed: {fedCount}";
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            var models = supplements.Models();
            ISupplement supplement = models.FirstOrDefault(x => x.GetType().Name == model);

            var robotsModels = robotRepository.Models();

            var robots = robotsModels.Where(x => !x.InterfaceStandards.Contains(supplement.InterfaceStandard));
            robots = robots.Where(x => x.Model == model);
            if (!robots.Any())
            {
                return $"All {model} are already upgraded!";
            }
            else
            {
                var robot = robots.First();
                robot.InstallSupplement(supplement);
                supplements.RemoveByName(supplementTypeName);
                return $"{model} is upgraded with {supplementTypeName}.";
            }
        }
    }
}
