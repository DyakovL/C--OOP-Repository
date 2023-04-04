using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWeightGained = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightGained => TigerWeightGained;

        public override IReadOnlyCollection<Type> PrefferredFoods => new HashSet<Type>() { typeof(Meat)};

        public override string ProduceSound()
        {
            return $"ROAR!!!";
        }
    }
}
