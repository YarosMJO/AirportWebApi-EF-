using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class DepartureRepository : BaseRepository, IRepository<Departure>
    {
        private AirportContext context;
        public DepartureRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.departures);
            context.SaveChanges();
        }

        public void Add(Departure entity)
        {
            context.Departures.Add(entity);
        }

        public IEnumerable<Departure> GetAll()
        {
            return context.Departures;
        }
        public void SetAll(List<Departure> entities)
        {
            entities.ForEach(x => context.Departures.Add(x));
        }

        public Departure GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Departures.Remove(item);
        }

        public void Update(Departure entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Departure GetItemByPredicate(Func<Departure, bool> predicate)
        {
            return context.Departures.Where(predicate).FirstOrDefault();
        }
    }
}
