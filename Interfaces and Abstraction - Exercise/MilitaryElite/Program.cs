using MilitaryElite.Core;
using MilitaryElite.Core.Interface;

namespace MilitaryElite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}