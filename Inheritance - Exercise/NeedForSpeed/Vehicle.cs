using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        private const double DefaultFuelConsumtion = 1.25;

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsumtion => DefaultFuelConsumtion;

        public virtual void Drive(double kilometers)
            => Fuel -= kilometers * FuelConsumtion;
    }
}
