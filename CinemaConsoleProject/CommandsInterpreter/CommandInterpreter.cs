using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
using CinemaConsoleProject.CommandsInterpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CinemaConsoleProject.CommandsInterpreter
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Suffix = "command";
        private const string InvalidCommandMessage = "Invalid Command Input!";

        private readonly IServiceProvider serviceProvider;
        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public string Read(string[] args)
        {
            var commandName = args[0].ToLower() + Suffix;

            var inputArgs = args
                .Skip(1)
                .ToArray();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName);

            if (type == null)
            {
                throw new ArgumentNullException(InvalidCommandMessage);
            }

            var constructor = type
                .GetConstructors()
                .FirstOrDefault();

            var constructorParams = constructor
                ?.GetParameters()
                .Select(x => x.ParameterType)
                .ToArray();

            var services = constructorParams
                ?.Select(this.serviceProvider.GetService)
                .ToArray();

            var typeInstance = Activator.CreateInstance(type, services) as ICommand;

            string result = typeInstance?.Execute(inputArgs);

            return result;
        }
    }
}
