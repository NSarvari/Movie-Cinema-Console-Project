namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using CinemaConsoleProject.Factories.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;
    using Validator;
    public class AddMovieCommand : ICommand
    {
        private readonly IRepository<IMovie> _movieRepository;
        private readonly IMovieFactory _movieFactory;
        public AddMovieCommand(IRepository<IMovie> movieRepository, IMovieFactory movieFactory)
        {
            _movieRepository = movieRepository;
            _movieFactory = movieFactory;
        }
        public string Execute(string[] inputArgs)
        {
            var movieType = inputArgs[0];
            var movie = _movieFactory.Create(movieType);
            _movieRepository.Add(movie);
            return string.Format($"Successfully added: {movie.GetType().Name}");
        }
    }
}
