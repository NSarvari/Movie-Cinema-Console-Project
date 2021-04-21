namespace CinemaConsoleProject
{
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories;
    using CinemaConsoleProject.Repositories.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    public class StartUp
    {
        static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();
            Console.WriteLine("Hello");
        }
        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IRepository<IMovie>, MovieRepository>();
            serviceCollection.AddSingleton<IRepository<IHourPeriod>, HourPeriordRepository>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
