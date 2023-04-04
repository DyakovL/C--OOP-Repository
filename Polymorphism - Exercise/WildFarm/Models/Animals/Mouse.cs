using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double MouseWeightGained = 0.10;
        public Mouse(string name, double weight, string livingRegion) :
            base(name, weight, livingRegion)
        {
        }

        public override double WeightGained => MouseWeightGained;

        public override IReadOnlyCollection<Type> PrefferredFoods => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit)};

        public override string ProduceSound()
        {
            return $"Squeak";
        }

        public override string ToString()
            => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
