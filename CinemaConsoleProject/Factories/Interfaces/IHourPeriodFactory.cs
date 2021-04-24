
namespace CinemaConsoleProject.Factories.Interfaces
{
    using CinemaConsoleProject.Models.Interfaces;
    public interface IHourPeriodFactory
    {
        IHourPeriod Create(string hourType, string currentHour);
    }
}
