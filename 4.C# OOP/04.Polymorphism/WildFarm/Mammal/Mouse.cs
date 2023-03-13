using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("Squeak");
        }

        public override void Feed(string food, double quantity)
        {
            if (food != "Vegetable" && food != "Fruit")
            {
                Console.WriteLine($"Mouse does not eat {food}!");
            }
            else
            {
                Weight += quantity * 0.1;
                FoodEaten += quantity;
            }
        }
    }
}
