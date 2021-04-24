namespace CinemaConsoleProject.Factories
{
    using CinemaConsoleProject.Factories.Interfaces;
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;
    using Validator;
    public class MovieFactory : IMovieFactory
    {
        public IMovie Create(string movieType)
        {
            var movieName = movieType.ToLower();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == movieName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, "Movie");

            var movie = Activator.CreateInstance(type) as IMovie;

            return movie;
        }
    }
}
