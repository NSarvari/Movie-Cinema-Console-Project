namespace CinemaConsoleProject.Repositories
{
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using Validator;

    class MovieRepository : IRepository<IMovie>
    {
        private readonly ICollection<IMovie> _movieRepository;
        private readonly string movieTitile = "Movie";
        public MovieRepository()
        {
            _movieRepository = new List<IMovie>();
        }
        public ICollection<IMovie> Repository => _movieRepository.ToList();
        public void Add(IMovie movie)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movie, movieTitile);
            _movieRepository.Add(movie);
        }
        public IMovie Get(string movie)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movie, movieTitile);
            var targetMovie = _movieRepository.FirstOrDefault(x => x.GetType().Name == movie);
            return targetMovie;
        }
        public bool Remove(IMovie movie)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movie, movieTitile);
            return _movieRepository.Remove(movie);
        }
    }
}
