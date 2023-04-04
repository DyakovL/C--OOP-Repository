using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.Factory;
using Raiding.Factory.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;
using System.Diagnostics;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IHeroCreation hero = new HeroCreation();

            IEngine engine = new Engine(reader, writer, hero);
            engine.Run();

        }
    }
}