using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Mammal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Ask()
        {
            Console.WriteLine("Meow");
        }
        public override void Feed(string food, double quantity)
        {
            if (food != "Meat" && food != "Vegetable")
            {
                Console.WriteLine($"Cat does not eat {food}!");
            }
            else
            {
                Weight += quantity * 0.3;
                FoodEaten += quantity;
            }
        }
    }
}
