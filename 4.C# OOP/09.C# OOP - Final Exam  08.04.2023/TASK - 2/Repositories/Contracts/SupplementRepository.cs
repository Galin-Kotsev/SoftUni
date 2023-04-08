using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories.Contracts
{
    public class SupplementRepository : IRepository<ISupplement>
    {
        private List<ISupplement> models;

        public SupplementRepository()
        {
            models = new List<ISupplement>();
        }

        public void AddNew(ISupplement model)
        {
            models.Add(model);
        }

        public ISupplement FindByStandard(int interfaceStandard) => models.FirstOrDefault(x => x.InterfaceStandard == interfaceStandard);

        public IReadOnlyCollection<ISupplement> Models() => models.AsReadOnly();

        public bool RemoveByName(string typeName)
        {
            var name 
                = models.FirstOrDefault(x=>x.GetType().Name == typeName);

            if (name != null)
            {
                models.Remove(name);
                return true;
            }

            return false;
        }
    }
}
