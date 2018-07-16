using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class CrewRepository : BaseRepository, IRepository<Crew>
    {
        private AirportContext context;
        public CrewRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.Crews);
            context.SaveChanges();
        }

        public void Add(Crew entity)
        {
            context.Crews.Add(entity);
        }

        public IEnumerable<Crew> GetAll()
        {
            return context.Crews;
        }
        public void SetAll(List<Crew> entities)
        {
            entities.ForEach(x => context.Crews.Add(x));
        }

        public Crew GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Crews.Remove(item);
        }

        public void Update(Crew entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Crew GetItemByPredicate(Func<Crew, bool> predicate)
        {
            return context.Crews.Where(predicate).FirstOrDefault();
        }
    }
}
