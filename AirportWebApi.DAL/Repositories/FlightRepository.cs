using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class FlightRepository : BaseRepository, IRepository<Flight>
    {
        private AirportContext context;
        public FlightRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.Flights);
            context.SaveChanges();
        }

        public void Add(Flight entity)
        {
            context.Flights.Add(entity);
        }

        public IEnumerable<Flight> GetAll()
        {
            return context.Flights;
        }
        public void SetAll(List<Flight> entities)
        {
            entities.ForEach(x => context.Flights.Add(x));
        }

        public Flight GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Flights.Remove(item);
        }

        public void Update(Flight entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Flight GetItemByPredicate(Func<Flight, bool> predicate)
        {
            return context.Flights.Where(predicate).FirstOrDefault();
        }
    }
}
