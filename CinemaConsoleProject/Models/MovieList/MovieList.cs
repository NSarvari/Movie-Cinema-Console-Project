namespace CinemaConsoleProject.Models.MovieList
{
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Validator;
    public class MovieList : IMovieList
    {
        private readonly List<IMovie> _movies;
        public MovieList()
        {
            _movies = new List<IMovie>();
        }
        public ICollection<IMovie> Movies => _movies.AsReadOnly();
        public void AddMovie(IMovie movie)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movie, nameof(movie));
            _movies.Add(movie);
        }
        public bool RemoveMovie(IMovie movie)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movie, nameof(movie));
            return _movies.Remove(movie);
        }
        public IMovie GetMovie(string movieName)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(movieName, nameof(movieName));
            return _movies.FirstOrDefault(m => m.GetType().Name == movieName);
        }
        public override string ToString()
        {
            return string.Join(",", _movies.Select(m => m.GetType().Name));
        }
    }
}
