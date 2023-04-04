using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models.Interface
{
    public interface IBuyer : INamable
    {
        public int Food { get; }

        void BuyFood();
    }
}
