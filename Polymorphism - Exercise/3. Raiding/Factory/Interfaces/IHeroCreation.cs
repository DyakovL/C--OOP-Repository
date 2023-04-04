using Raiding.Models.Interfaces;

namespace Raiding.Factory.Interfaces
{
    public interface IHeroCreation
    {
        IBaseHero CreateHero(string heroType, string name, int power);
    }
}
