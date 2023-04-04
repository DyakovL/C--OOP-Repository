using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }


        public override double IncreasedConsumption => 1.4;

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
            base.Refuel(amount);
        }
    }
}
