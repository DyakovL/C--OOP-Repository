﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Cars
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumtion = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumtion => DefaultFuelConsumtion;
    }
}
