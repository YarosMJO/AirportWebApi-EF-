using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWebApi.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(int id);

        TEntity GetItemByPredicate(Func<TEntity, bool> predicate);

    }
    public abstract class EntityBase
    {
        [Required]
        public int Id { get; set; }
    }
}