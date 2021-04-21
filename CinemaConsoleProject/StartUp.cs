namespace CinemaConsoleProject
{
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories;
    using CinemaConsoleProject.Repositories.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using Engine;
    using CinemaConsoleProject.Engine.Interfaces;
    using CommandsInterpreter;
    using CinemaConsoleProject.CommandsInterpreter.Interfaces;

    public class StartUp
    {
        static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();
            IEngine engine = serviceProvider.GetService<IEngine>();
            engine.Run();
        }
        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IEngine, StartEngine>();

            serviceCollection.AddSingleton<IRepository<IMovie>, MovieRepository>();
            serviceCollection.AddSingleton<IRepository<IHourPeriod>, HourPeriordRepository>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
