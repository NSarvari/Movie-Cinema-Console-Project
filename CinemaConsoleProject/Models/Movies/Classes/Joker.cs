namespace CinemaConsoleProject.Models.Movies.Classes
{
    using CinemaConsoleProject.Models.Movies.Abstractions;
    public class Joker : Movie
    {
        private const string JockerHallNumber = "A";
        public Joker() : base(JockerHallNumber)
        {
        }
    }
}
