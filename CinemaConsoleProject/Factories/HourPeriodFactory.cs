namespace CinemaConsoleProject.Factories
{
    using CinemaConsoleProject.Factories.Interfaces;
    using CinemaConsoleProject.Models.Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;
    using Validator;

    public class HourPeriodFactory : IHourPeriodFactory
    {
        public IHourPeriod Create(string hourType, string currentHour)
        {
            var clientName = hourType.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == clientName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, "Hour Type");

            var hour = Activator.CreateInstance(type, currentHour) as IHourPeriod;

            return hour;
        }
    }
}
