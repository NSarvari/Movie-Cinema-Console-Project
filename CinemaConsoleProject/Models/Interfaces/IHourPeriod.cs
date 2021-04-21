using CinemaConsoleProject.Models.MovieList;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.Models.Interfaces
{
    public interface IHourPeriod
    {
        IMovieList MovieList { get; }
    }
}
