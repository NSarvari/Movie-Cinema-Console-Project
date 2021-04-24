namespace CinemaConsoleProject.Models.Movies.Classes
{
    using CinemaConsoleProject.Models.Movies.Abstractions;
    public class Joker : Movie
    {
        private const string JockerDirector = "Todd Phillips";
        public Joker() : base(JockerDirector)
        {
        }
    }
}
