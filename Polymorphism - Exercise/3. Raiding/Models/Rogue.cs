using Raiding.Models.Interfaces;

namespace Raiding.Models
{
    public class Rogue : BaseHero, IBaseHero
    {
        private const int RoguePower = 80;

        public Rogue(string name, int power) : base(name, power)
        {
        }

        public override int Power => RoguePower;

        public override string CastAbility()
         => $"{GetType().Name} - {this.Name} hit for {Power} damage";
    }
}
