using FoodShortage.Core.Interface;
using FoodShortage.IO.Interfaces;
using FoodShortage.Models;
using FoodShortage.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Core
{
    public class Engine : IEngine
    {
        
        List<IBuyer> buyers;
        IReader reader;
        IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;

            buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int input = int.Parse(reader.ReadLine());

            for (int i = 0; i < input; i++)
            {
                try
                {
                    string[] cmdArgs = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    ProcessInput(cmdArgs);
                }
                catch (Exception ex) { }
            }

            int sum = 0;
            string command;

            while ((command = reader.ReadLine()) != "End")
            {
                try
                {
                    if (!buyers.Any(x => x.Name == command))
                    {
                        throw new ArgumentException();
                    }

                    buyers.FirstOrDefault(buyer => buyer.Name == command).BuyFood();
                }
                catch (Exception) { }
            }

            writer.WriteLine(buyers.Sum(b => b.Food));

        }

        private void ProcessInput(string[] cmdArgs)
        {
            
            string name = cmdArgs[0];
            if (cmdArgs.Length == 4)
            {
                int age = int.Parse(cmdArgs[1]);
                string id = cmdArgs[2];
                string birthday = cmdArgs[3];
                IBuyer citizen = new Citizens(name, id, age, birthday);
                buyers.Add(citizen);

            }
            else
            {
                int age = int.Parse(cmdArgs[1]);
                string group = cmdArgs[2];
                IBuyer rebel = new Rebel(name, age, group);
                buyers.Add(rebel);
            }   
        }
    }

}
