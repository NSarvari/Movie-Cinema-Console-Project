namespace CinemaConsoleProject.Models.Movies.Abstractions
{
    using CinemaConsoleProject.Models.Movies.Interfaces;
    using Validator;
    public abstract class Movie : IMovie
    {
        private string _hallNumber;
        public Movie(string hallNumber)
        {
            _hallNumber = hallNumber;
        }
        public string HallNumber
        {
            get
            {
                return _hallNumber;
            }
            private set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(nameof(this.HallNumber), value);
                _hallNumber = value;
            }
        }
    }
}
