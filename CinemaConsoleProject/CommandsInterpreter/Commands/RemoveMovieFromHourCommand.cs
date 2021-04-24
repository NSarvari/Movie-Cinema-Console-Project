namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;

    public class RemoveMovieFromHourCommand : ICommand
    {

        private readonly IRepository<IMovie> _movieRepository;
        private readonly IRepository<IHourPeriod> _hourPeriodRepository;
        public RemoveMovieFromHourCommand(IRepository<IMovie> movieRepository, IRepository<IHourPeriod> hourPeriodRepository)
        {
            _movieRepository = movieRepository;
            _hourPeriodRepository = hourPeriodRepository;
        }
        public string Execute(string[] inputArgs)
        {
            string movieName = inputArgs[0];
            string hourName = inputArgs[1];
            var movie = _movieRepository.Get(movieName);
            var hour = _hourPeriodRepository.Get(hourName);
            hour.MovieList.RemoveMovie(movie);
            return $"Successfuly remove {movieName} from {hourName}";
        }
    }
}
