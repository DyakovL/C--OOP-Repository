using FoodShortage.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Citizens : IIdentifiable, IBirthable, IBuyer, INamable
    {
        private const int FoodIncrement = 10;

        public Citizens(string name, string id, int age, string birthday)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthday = birthday;
        }

        public string Id { get; private set; }

        

        public string Birthday { get; private set; }

        public int Food { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public void BuyFood()
        {
            Food += FoodIncrement;
        }
    }
}
