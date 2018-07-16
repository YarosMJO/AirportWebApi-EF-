using AirportWebApi.DAL.Repositories;

namespace AirportWebApi.DAL
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class;
        void SaveChanges();
    }
}
