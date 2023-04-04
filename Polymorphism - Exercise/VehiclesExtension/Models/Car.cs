using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CarIncreasedConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double IncreasedConsumption => CarIncreasedConsumption;

        public override void Refuel(double amount)
        {
            if ( amount > tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            else if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            base.Refuel(amount);
        }
    }
}
