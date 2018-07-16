using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class TicketRepository : BaseRepository, IRepository<Ticket>
    {
        private AirportContext context;
        public TicketRepository(AirportContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            SetAll(seeder.Tickets);
            context.SaveChanges();
        }

        public void Add(Ticket entity)
        {
            context.Tickets.Add(entity);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return context.Tickets;
        }
        public void SetAll(List<Ticket> entities)
        {
            entities.ForEach(x => context.Tickets.Add(x));
        }

        public Ticket GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public void Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item == null) return;
            context.Tickets.Remove(item);
        }

        public void Update(Ticket entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item == null) return;
            context.Entry(entity).CurrentValues.SetValues(item);
        }

        public Ticket GetItemByPredicate(Func<Ticket, bool> predicate)
        {
            return context.Tickets.Where(predicate).FirstOrDefault();
        }
    }
}
