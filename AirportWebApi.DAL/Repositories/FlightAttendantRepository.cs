using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class FlightAttendantRepository : BaseRepository, IRepository<FlightAttendant>
    {
        private AirportContext context;
        public FlightAttendantRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.FlightAttendants);
            context.SaveChanges();
        }

        public void Add(FlightAttendant entity)
        {
            context.FlightAttendants.Add(entity);
        }

        public IEnumerable<FlightAttendant> GetAll()
        {
            return context.FlightAttendants;
        }
        public void SetAll(List<FlightAttendant> entities)
        {
            entities.ForEach(x => context.FlightAttendants.Add(x));
        }

        public FlightAttendant GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.FlightAttendants.Remove(item);
        }

        public void Update(FlightAttendant entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public FlightAttendant GetItemByPredicate(Func<FlightAttendant, bool> predicate)
        {
            return context.FlightAttendants.Where(predicate).FirstOrDefault();
        }
    }
}
