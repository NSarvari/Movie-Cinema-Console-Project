using CinemaConsoleProject.Models.Movies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.Models.MovieList
{
    public interface IMovieList
    {
        ICollection<IMovie> Movies { get; }
        void AddMovie(IMovie movie);
        bool RemoveMovie(IMovie movie);
        IMovie GetMovie(string movie);
    }
}
