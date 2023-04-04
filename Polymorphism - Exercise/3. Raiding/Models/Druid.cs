using Raiding.Models.Interfaces;

namespace Raiding.Models
{
    public class Druid : BaseHero, IBaseHero
    {
        private const int DruidPower = 80;

        public Druid(string name, int power): base(name, power)
        {
        }

        public override int Power => DruidPower;

        public override string CastAbility()
         => $"{GetType().Name} - {this.Name} healed for {Power}";
    }
}
