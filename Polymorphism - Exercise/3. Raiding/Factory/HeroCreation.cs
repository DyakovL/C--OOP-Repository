using Raiding.Factory.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;

namespace Raiding.Factory
{
    public class HeroCreation : IHeroCreation
    {
        public IBaseHero CreateHero(string heroType, string name, int power)
        {
            switch (heroType)
            {
                case "Druid":
                    return new Druid(name, power);
                case "Warrior":
                    return new Warrior(name, power);
                case "Paladin":
                    return new Paladin(name, power);
                case "Rogue":
                    return new Rogue(name, power);
                default:
                    throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
