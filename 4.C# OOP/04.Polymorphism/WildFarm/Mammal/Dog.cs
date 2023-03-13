using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Mammal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("Woof!");
        }

        public override void Feed(string food, double quantity)
        {
            if (food != "Meat")
            {
                Console.WriteLine($"Dog does not eat {food}!");
            }
            else
            {
                Weight += quantity * 0.4;
                FoodEaten += quantity;
            }
        }
    }
}
