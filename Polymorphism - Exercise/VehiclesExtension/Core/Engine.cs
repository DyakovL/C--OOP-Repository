using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.Models.Interfaces;
using VehiclesExtension.IO.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {

        private IReader  reader;
        private IWriter writer;
        private IVehicleFactories vehicleFacotry;

        private ICollection<IVehicle> vehicles;

        public Engine(IReader reader, IWriter writer, IVehicleFactories vehicleFacotry)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFacotry= vehicleFacotry;
            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle());

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
                catch(Exception)
                {
                    throw;
                }
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }

        }

        private void ProcessCommand()
        {
            string[] commandTokens = reader.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = commandTokens[0];
            string vehicleType = commandTokens[1];

            IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            if (command == "Drive")
            {
                double distance = double.Parse(commandTokens[2]);
                writer.WriteLine(vehicle.Drive(distance));
            }
            else if (command == "Refuel")
            {
                double amount = double.Parse(commandTokens[2]);
                vehicle.Refuel(amount);
            }
            else if (command == "DriveEmpty")
            {
                double distance = double.Parse(commandTokens[2]);
                writer.WriteLine(vehicle.DriveEmpty(distance));
            }
        }

        private IVehicle CreateVehicle()
        {
            string[] tokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = tokens[0];
            double quantity = double.Parse(tokens[1]);
            double litersPerKm = double.Parse(tokens[2]);
            int tankCapacity = int.Parse(tokens[3]);

            if (quantity > tankCapacity)
            {
                quantity = 0;
            }

            return vehicleFacotry.Create(type, quantity, litersPerKm, tankCapacity);
        }
    }
}
