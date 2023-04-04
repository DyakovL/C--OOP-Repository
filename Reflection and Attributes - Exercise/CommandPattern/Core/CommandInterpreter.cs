using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string input)
        {
            string[] args = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = args[0];

            string[] cmdArgs = args.Skip(1).ToArray();

            Type cmdType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{name}Command");

            if (cmdType is null)
            {
                throw new ArgumentNullException("Command not found");
            }

            ICommand commandInstance =
                Activator.CreateInstance(cmdType) as ICommand;

            string result = commandInstance.Execute(cmdArgs);

            return result.ToString();
        }
    }
}
