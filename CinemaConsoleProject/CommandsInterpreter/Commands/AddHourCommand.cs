namespace CinemaConsoleProject.CommandsInterpreter.Commands
{
    using CinemaConsoleProject.CommandsInterpreter.Commands.Interfaces;
    using CinemaConsoleProject.Factories.Interfaces;
    using CinemaConsoleProject.Models.Interfaces;
    using CinemaConsoleProject.Repositories.Interfaces;
    public class AddHourCommand : ICommand

    {
        private readonly IRepository<IHourPeriod> _hourPeriodRepository;
        private readonly IHourPeriodFactory _hourPeriodFactory;
        public AddHourCommand(IRepository<IHourPeriod> hourPeriodRepository, IHourPeriodFactory hourPeriodFactory)
        {
            _hourPeriodRepository = hourPeriodRepository;
            _hourPeriodFactory = hourPeriodFactory;
        }
        public string Execute(string[] inputArgs)
        {
            var hourType = inputArgs[0];
            string currentHour = inputArgs[1];
            var hour = _hourPeriodFactory.Create(hourType,currentHour);
            _hourPeriodRepository.Add(hour);
            return $"Successfully added: {hour.GetType().Name}";
        }
    }
}
