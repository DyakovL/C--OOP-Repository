using FoodShortage.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer, INamable
    {
        private const int FoodIncrement = 5;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Group { get; private set; }

        public int Food { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public void BuyFood()
        {
            Food += FoodIncrement;
        }
    }
}
