namespace CinemaConsoleProject.Models.Movies.Classes
{
    using CinemaConsoleProject.Models.Movies.Abstractions;
    public class RomeoAndJuliet : Movie
    {
        private const string RomeoAndJulietDirector = "Carlo Carlei";
        public RomeoAndJuliet() : base(RomeoAndJulietDirector)
        {

        }
        
    }
}
