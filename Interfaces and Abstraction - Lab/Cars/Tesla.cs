using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        public Tesla(string model, string color, int battery) 
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public int Battery {get; private set;}

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            Console.WriteLine($"{this.Color} {GetType().Name} {this.Model} with {this.Battery} Batteries");
            return $"{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
