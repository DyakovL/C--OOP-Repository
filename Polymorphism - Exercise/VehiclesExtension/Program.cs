using Vehicles.Core;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsnoleWriter();
            IVehicleFactories factory = new VehicleFactory();

            Engine engine = new Engine(reader, writer, factory);
            engine.Run();
        }
    }
}