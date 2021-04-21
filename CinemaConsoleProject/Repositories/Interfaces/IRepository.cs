namespace CinemaConsoleProject.Repositories.Interfaces
{
    using System.Collections.Generic;
    public interface IRepository<T>
    {
        ICollection<T> Repository { get; }
        void Add(T input);
        bool Remove(T input);
        T Get(string input);
    }
}
