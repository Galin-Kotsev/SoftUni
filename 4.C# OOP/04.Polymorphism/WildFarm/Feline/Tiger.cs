using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Mammal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override void Feed(string food, double quantity)
        {
            if (food != "Meat")
            {
                Console.WriteLine($"Tiger does not eat {food}!");
            }
            else
            {
                Weight += quantity * 1;
                FoodEaten += quantity;
            }
        }
    }
}
