using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double OwlWeightGained = 0.25;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightGained => OwlWeightGained;

        public override IReadOnlyCollection<Type> PrefferredFoods
            => new HashSet<Type>() { typeof(Meat)}; 

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }
    }
}
