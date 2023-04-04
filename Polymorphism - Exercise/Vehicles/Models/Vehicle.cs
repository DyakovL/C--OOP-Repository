using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public double fuelQuantity  {get; private set;}

        public double fuelConsumption  {get; private set;}

        public abstract double IncreasedConsumption { get; }

        public double tankCapacity
        {
            get
            {
                return tankCapacity;
            }
            private set
            {
                if (tankCapacity <= 0)
                {
                    throw new ArgumentException("You need fuel to start");
                }
                tankCapacity = value;
            }
        }

        public string Drive(double distance)
        {
            double totalConsumption = fuelConsumption + IncreasedConsumption;

            if (fuelQuantity <= distance * totalConsumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            fuelQuantity -= distance * totalConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public string DriveEmpty(double distance)
        {
            double totalConsumption = fuelConsumption * distance;

            if (fuelQuantity <= totalConsumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            fuelQuantity -= totalConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount) => fuelQuantity += amount;

        public override string ToString()
                => $"{this.GetType().Name}: {fuelQuantity:F2}";

    }
}
