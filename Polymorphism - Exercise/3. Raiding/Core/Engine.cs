using Raiding.Core.Interfaces;
using Raiding.Factory.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;    

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IHeroCreation hero;

        private readonly ICollection<IBaseHero> heroes;

        public Engine(IReader reader, IWriter writer, IHeroCreation hero)
        {
            this.reader = reader;
            this.writer = writer;
            this.hero = hero;

            heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int n = int.Parse(reader.ReadLine());
            int sum = 0;
            IBaseHero currHero = null;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    currHero = Creator();
                    sum += currHero.Power;
                    heroes.Add(currHero);
                }
                catch (ArgumentException fe)
                {

                    writer.WriteLine(fe.Message);
                    i--;
                }
            }
            int bossPower = int.Parse(reader.ReadLine());

            foreach (var item in heroes)
            {
                writer.WriteLine(item.CastAbility());
            }

            if (sum >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }

        private IBaseHero Creator()
        {
            string name = reader.ReadLine();
            string heroType = reader.ReadLine();
            int power = 0;

            IBaseHero currHero = hero.CreateHero(heroType, name, power);
            return currHero;
        }
    }
}
