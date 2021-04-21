namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using System;
    public class ExitCommand : ICommand
    {
        public string Execute(string[] inputArgs)
        {
            Console.WriteLine("The app was successfully stopped!");
            Environment.Exit(0);
            return null;
        }
    }
}
