using BirthdayCelebrations.Core;
using BirthdayCelebrations.IO;
using BirthdayCelebrations.IO.Interfaces;

namespace BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine= new Engine(reader, writer);
            engine.Run();
        }
    }
}