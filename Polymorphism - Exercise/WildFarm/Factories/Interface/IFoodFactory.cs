﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories.Interface
{
    public interface IFoodFactory
    {
        IFood CreateFood(string type, int quantity);
    }
}
