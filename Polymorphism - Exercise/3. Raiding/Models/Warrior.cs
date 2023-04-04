using Raiding.Models.Interfaces;

namespace Raiding.Models
{
    public class Warrior : BaseHero, IBaseHero
    {
        private const int WarriorPower = 100;

        public Warrior(string name, int power) : base(name, power)
        {
        }

        public override int Power => WarriorPower;

        public override string CastAbility()
         => $"{GetType().Name} - {this.Name} hit for {Power} damage";



    }
}
