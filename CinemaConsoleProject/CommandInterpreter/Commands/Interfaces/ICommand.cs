namespace CinemaConsoleProject.CommandInterpreter.Commands.Interfaces
{
    public interface ICommand
    {
        string Execute(string[] inputArgs);
    }
}
