using AirportWebApi.DAL;
using System.Collections.Generic;

namespace AirportWebApi.BL.Services
{
    public class BaseService
    {
        private IUow repositories;
        public BaseService(IUow uow)
        {
            repositories = uow;
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return repositories.GetRepository<T>().GetAll();
        }
        public T GetById<T>(int id) where T : class
        {
            return repositories.GetRepository<T>().GetById(id);
        }

        public void Add<T>(T item) where T : class
        {
            repositories.GetRepository<T>().Add(item);
        }

        public void Update<T>(T item) where T : class
        {
            repositories.GetRepository<T>().Update(item);
        }

        public void Remove<T>(int id) where T : class
        {
            repositories.GetRepository<T>().Remove(id);
        }

        public void SaveChanges()
        {
            repositories.SaveChanges();
        }
    }
}
