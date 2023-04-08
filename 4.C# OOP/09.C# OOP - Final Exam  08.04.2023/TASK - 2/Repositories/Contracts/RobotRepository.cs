using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories.Contracts
{
    public class RobotRepository : IRepository<IRobot>
    {
        private List<IRobot> models;

        public RobotRepository()
        {
            models = new List<IRobot>();
        }

        public void AddNew(IRobot model)
        {
            models.Add(model);
        }

        public IRobot FindByStandard(int interfaceStandard) => models.FirstOrDefault(x => x.InterfaceStandards.Contains(interfaceStandard));


        public IReadOnlyCollection<IRobot> Models()=> models;

        public bool RemoveByName(string typeName)
        {
            var name
                = models.FirstOrDefault(x => x.GetType().Name == typeName);

            if (name != null)
            {
                models.Remove(name);
                return true;
            }

            return false;
        }
    }
}
