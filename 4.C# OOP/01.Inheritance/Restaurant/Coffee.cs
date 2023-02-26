using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private double caffeine;

        public Coffee(string name, double caffeine) 
            : base(name, 3.50M, 50)
        {
            Caffeine = caffeine;
        }

        
        public double Caffeine
        {
            get { return caffeine; }
            set { caffeine = value; }
        }

    }
}
