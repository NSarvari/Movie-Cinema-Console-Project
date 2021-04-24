namespace CinemaConsoleProject.Models.Movies.Classes
{
    using CinemaConsoleProject.Models.Movies.Abstractions;
    public class RomeoAndJuliet : Movie
    {
        private const string RomeoAndJulietHallNumber = "VIP";
        public RomeoAndJuliet() : base(RomeoAndJulietHallNumber)
        {

        }
        
    }
}
