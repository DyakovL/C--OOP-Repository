using Raiding.Models.Interfaces;

namespace Raiding.Models
{
    public class Paladin : BaseHero, IBaseHero
    {
        private const int PaladinPower = 100;
        public Paladin(string name, int power) : base(name, power)
        {
        }

        public override int Power => PaladinPower;

        public override string CastAbility()
        => $"{GetType().Name} - {this.Name} healed for {Power}";
    }
}
