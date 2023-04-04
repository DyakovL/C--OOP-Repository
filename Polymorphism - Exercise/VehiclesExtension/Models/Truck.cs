using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        public const double TrickIncreasedConsumpion = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double IncreasedConsumption => TrickIncreasedConsumpion;

        public override void Refuel(double amount)
        {
            if (amount > tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            base.Refuel(amount * 0.95);
        }
    }
}
