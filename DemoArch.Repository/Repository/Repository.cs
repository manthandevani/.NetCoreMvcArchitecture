using DemoArch.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoArch.Repository.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entities;

        protected Repository(DemoContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public TEntity GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }
    }
}
