namespace CinemaConsoleProject.Models.Movies.Abstractions
{
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using Validator;
    public abstract class Movie : IMovie
    {
        private string _director;
        public Movie(string hallNumber)
        {
            _director = hallNumber;
        }
        public string Director
        {
            get
            {
                return _director;
            }
            private set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(nameof(this.Director), value);
                _director = value;
            }
        }
    }
}
