namespace CinemaConsoleProject.Models.Abstractions
{
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Models.MovieList;
    using Validator;
    public abstract class HourPeriod : IHourPeriod , IIdentifiable
    {
        private string _currentHour;
        public HourPeriod(string currentHour)
        {
            this.CurrentHour = currentHour;
            this.MovieList = new MovieList();
        }
        public string CurrentHour
        {
            get
            {
                return _currentHour;
            }
            set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(nameof(this.CurrentHour), value);
                _currentHour = value;
            }
        }
        public IMovieList MovieList { get; }
    }
}
