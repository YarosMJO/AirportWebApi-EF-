using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class PilotRepository : BaseRepository, IRepository<Pilot>
    {
        private AirportContext context;
        public PilotRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.Pilots);
            context.SaveChanges();
        }

        public void Add(Pilot entity)
        {
            context.Pilots.Add(entity);
        }

        public IEnumerable<Pilot> GetAll()
        {
            return context.Pilots;
        }
        public void SetAll(List<Pilot> entities)
        {
            entities.ForEach(x => context.Pilots.Add(x));
        }

        public Pilot GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Pilots.Remove(item);
        }

        public void Update(Pilot entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Pilot GetItemByPredicate(Func<Pilot, bool> predicate)
        {
            return context.Pilots.Where(predicate).FirstOrDefault();
        }
    }
}