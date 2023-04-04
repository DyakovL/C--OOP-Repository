using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {

        public double fuelQuantity { get;}

        public double fuelConsumption { get; }

        public int tankCapacity { get;}

        public string Drive(double distance);

        public string DriveEmpty(double distance);

        public void Refuel(double amount);
    }
}
