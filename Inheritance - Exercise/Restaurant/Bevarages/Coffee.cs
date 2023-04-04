using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bevarages
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50M;
        private const double CoffeeMililiters = 50;

        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMililiters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
