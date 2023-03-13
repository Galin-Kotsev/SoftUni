using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Bird
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("Cluck");
        }

        public override void Feed(string food, double quantity)
        {
            Weight += quantity * 0.35;
            FoodEaten += quantity;
        }
    }
}
