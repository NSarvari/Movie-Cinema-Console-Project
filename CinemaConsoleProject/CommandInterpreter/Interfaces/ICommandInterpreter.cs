using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.CommandInterpreter.Interfaces
{
    public interface ICommandInterpreter
    {
        string Read(string[] args);
    }
}
