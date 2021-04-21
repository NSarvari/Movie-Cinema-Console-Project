namespace CinemaConsoleProject.Models.Classes
{
    using CinemaConsoleProject.Models.Abstractions;
    class DayHours : HourPeriod
    {
        public DayHours(string currentHour) : base(currentHour)
        {
        }
    }
}