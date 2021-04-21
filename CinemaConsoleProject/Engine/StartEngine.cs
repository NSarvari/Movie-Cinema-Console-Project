namespace CinemaConsoleProject.Engine
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using CinemaConsoleProject.Engine.Interfaces;
    using CinemaConsoleProject.CommandsInterpreter.Interfaces;

    public class StartEngine : IEngine
    {
        private readonly IServiceProvider _serviceProvider;
        public StartEngine(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void Run()
        {
            while (true)
            {
                var inputArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var result = _serviceProvider.GetService<ICommandInterpreter>().Read(inputArray);
                Console.WriteLine(result);
            }
        }
    }
}
