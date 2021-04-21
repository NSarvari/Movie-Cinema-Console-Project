namespace CinemaConsoleProject.Engine
{
    using System;
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
                Console.WriteLine();
            }
        }
    }
}
