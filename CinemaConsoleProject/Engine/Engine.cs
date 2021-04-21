namespace CinemaConsoleProject.Engine
{
    using CinemaConsoleProject.CommandInterpreter.Interfaces;
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class Engine : IEngine
    {
        private readonly IServiceProvider _serviceProvider;
        public Engine(IServiceProvider serviceProvider)
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
