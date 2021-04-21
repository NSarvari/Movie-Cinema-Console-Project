using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
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
