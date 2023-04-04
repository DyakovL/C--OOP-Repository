using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bevarages
{
    public abstract class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double mililiters) : base(name, price, mililiters)
        {
        }
    }
}
