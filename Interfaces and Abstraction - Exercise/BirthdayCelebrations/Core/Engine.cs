using BirthdayCelebrations.Core.Interface;
using BirthdayCelebrations.IO.Interfaces;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Core
{
    public class Engine : IEngine
    {
        List<IBirthable> birthdays;
        List<IIdentifiable> identifiers;
        IReader reader;
        IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;

            identifiers = new List<IIdentifiable>();    
            birthdays = new List<IBirthable>();
        }

        public void Run()
        {
            string input;

            while ((input = reader.ReadLine()) != "End")
            {
                try
                {
                    string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    ProcessInput(cmdArgs);
                }
                catch (Exception ex) { }
            }

            string birthYear = reader.ReadLine();

            foreach (var item in birthdays)
            {
                if (item.Birthday.EndsWith(birthYear))
                {
                    writer.WriteLine(item.Birthday);
                }
            }
        }


        private void ProcessInput(string[] cmdArgs)
        {
            
            string type = cmdArgs[0];
            if (type == "Citizen")
            {
                string name = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string id = cmdArgs[3];
                string birthday = cmdArgs[4];
                IBirthable citizen = new Citizens(name, id, age, birthday);
                birthdays.Add(citizen);

            }
            else if (type == "Pet")
            {
                string name = cmdArgs[1];
                string birthday = cmdArgs[2];

                IBirthable pet = new Pet(name, birthday);
                birthdays.Add(pet);

            }
            else
            {
                string name = cmdArgs[1];
                string id = cmdArgs[2];
                IIdentifiable robot = new Robots(name, id);
                identifiers.Add(robot);

            }
        }
    }

}
