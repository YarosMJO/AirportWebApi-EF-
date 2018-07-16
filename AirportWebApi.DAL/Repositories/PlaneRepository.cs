using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class PlaneRepository : BaseRepository, IRepository<Plane>
    {
        private AirportContext context;
        public PlaneRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.Planes);
            context.SaveChanges();
        }

        public void Add(Plane entity)
        {
            context.Planes.Add(entity);
        }

        public IEnumerable<Plane> GetAll()
        {
            return context.Planes;
        }
        public void SetAll(List<Plane> entities)
        {
            entities.ForEach(x => context.Planes.Add(x));
        }

        public Plane GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Planes.Remove(item);
        }

        public void Update(Plane entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Plane GetItemByPredicate(Func<Plane, bool> predicate)
        {
            return context.Planes.Where(predicate).FirstOrDefault();
        }
    }
}
