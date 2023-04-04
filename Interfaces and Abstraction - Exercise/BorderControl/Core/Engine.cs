using BorderControl.Core.Interface;
using BorderControl.Models;
using BorderControl.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        List<IIdentifiable> identifiers;

        public Engine()
        {
            identifiers = new List<IIdentifiable>();    
        }

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    ProcessInput(cmdArgs);
                }
                catch (Exception ex) { }
            }

            string endingNumberOfIds = Console.ReadLine();

            foreach (var item in identifiers)
            {
                if (item.Id.EndsWith(endingNumberOfIds))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }


        private void ProcessInput(string[] cmdArgs)
        {
            
            string name = cmdArgs[0];
            if (cmdArgs.Length == 3)
            {
                int age = int.Parse(cmdArgs[1]);
                string id = cmdArgs[2];
                IIdentifiable citizen = new Citizens(id, name, age);
                identifiers.Add(citizen);

            }
            else
            {
                string id = cmdArgs[1];
                IIdentifiable robot = new Robots(id, name);
                identifiers.Add(robot);

            }
        }
    }

}
