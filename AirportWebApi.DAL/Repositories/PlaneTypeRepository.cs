using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class PlaneTypeRepository : BaseRepository, IRepository<PlaneType>
    {
        private AirportContext context;
        public PlaneTypeRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.PlaneTypes);
            context.SaveChanges();
        }

        public void Add(PlaneType entity)
        {
            context.PlaneTypes.Add(entity);
        }

        public IEnumerable<PlaneType> GetAll()
        {
            return context.PlaneTypes;
        }
        public void SetAll(List<PlaneType> entities)
        {
            entities.ForEach(x => context.PlaneTypes.Add(x));
        }

        public PlaneType GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.PlaneTypes.Remove(item);
        }

        public void Update(PlaneType entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public PlaneType GetItemByPredicate(Func<PlaneType, bool> predicate)
        {
            return context.PlaneTypes.Where(predicate).FirstOrDefault();
        }
    }
}
