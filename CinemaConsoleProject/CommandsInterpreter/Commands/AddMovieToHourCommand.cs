namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;

    public class AddMovieToHourCommand : ICommand
    {
        private readonly IRepository<IMovie> _movieRepository;
        private readonly IRepository<IHourPeriod> _hourRepository;
        public AddMovieToHourCommand(IRepository<IMovie> movieRepository, IRepository<IHourPeriod> hourRepository)
        {
            _movieRepository = movieRepository;
            _hourRepository = hourRepository;
        }
        public string Execute(string[] inputArgs)
        {
            string hourName = inputArgs[1];
            string movieName = inputArgs[0];
            var hour = _hourRepository.Get(hourName);
            var movie = _movieRepository.Get(movieName);
            hour.MovieList.AddMovie(movie);
            return $"Successfuly added {movieName} to {hourName}";
        }

    }
}
