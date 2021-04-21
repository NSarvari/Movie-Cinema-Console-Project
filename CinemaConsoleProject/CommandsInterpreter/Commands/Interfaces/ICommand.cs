namespace CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces
{
    public interface ICommand
    {
        string Execute(string[] inputArgs);
    }
}
