namespace CinemaConsoleProject.Models.Classes
{
    using CinemaConsoleProject.Models.Abstractions;
    public class NightHours : HourPeriod
    {
        public NightHours(string currentHour) : base(currentHour)
        {            
        }
    }
}
