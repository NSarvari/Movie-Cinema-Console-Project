namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;

    public class ShowCurrentHourCommand : ICommand
    {
        private readonly IRepository<IHourPeriod> _hourPeriodRepository;
        public ShowCurrentHourCommand(IRepository<IHourPeriod> hourPeriodRepository)
        {
            _hourPeriodRepository = hourPeriodRepository;
        }
        public string Execute(string[] inputArgs)
        {
            string currentHour = inputArgs[0];
            var hour = _hourPeriodRepository.Get(currentHour);
            if(hour.MovieList.Movies.Count == 0)
            {
                return $"No movies for {currentHour}";
            }
            else
            {
                return $"Hour: {currentHour}\nMovies:\n{string.Join(",",hour.MovieList)}";
            }
        }
    }
}
