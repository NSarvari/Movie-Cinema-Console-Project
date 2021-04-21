namespace CinemaConsoleProject.Repositories
{
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using Validator;
    public class HourPeriordRepository : IRepository<IHourPeriod>
    {
        private readonly ICollection<IHourPeriod> _hourPeriods;
        private readonly string hourPeriodTitle = "HourPeriod";
        public HourPeriordRepository()
        {
            _hourPeriods = new List<IHourPeriod>();
        }
        public ICollection<IHourPeriod> Repository => _hourPeriods.ToImmutableArray();
        public void Add(IHourPeriod hourPeriod)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(hourPeriod, hourPeriodTitle);
            _hourPeriods.Add(hourPeriod);
        }
        public bool Remove(IHourPeriod hourPeriod)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(hourPeriod, hourPeriodTitle);
            return _hourPeriods.Remove(hourPeriod);
        }
        public IHourPeriod Get(string hourPeriod)
        {
            var targetHourPeriod = _hourPeriods.FirstOrDefault(h => (h as IIdentifiable).CurrentHour == hourPeriod);
            Validator.ThrowAnExceptionIfObjectIsNull(targetHourPeriod, hourPeriod);
            return targetHourPeriod;
        }
    }
}
