namespace CinemaConsoleProject.Factories.Interfaces
{
    using CinemaConsoleProject.Models.Movies.Interfaces;
    public interface IMovieFactory
    {
        IMovie Create(string movieType);

    }
}
