﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CarIncreasedConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double IncreasedConsumption => CarIncreasedConsumption;

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }
    }
}
