using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Feed(string food, double quantity)
        {
            if (food != "Meat")
            {
                Console.WriteLine($"Owl does not eat {food}!");
            }
            else
            {
                Weight += quantity * 0.25;
                FoodEaten += quantity;
            }
        }
    }
}
