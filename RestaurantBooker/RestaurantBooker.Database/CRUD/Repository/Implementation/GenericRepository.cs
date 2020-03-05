using ClassLibrary1.CRUD.Repository.Interfaces;
using RestaurantBocker.Database.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary1.CRUD.Repository.Implementation
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DatabaseContext databaseContext;
        private DbSet<TEntity> dbSetEntity;

        public GenericRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
            this.dbSetEntity = databaseContext.Set<TEntity>();
        }
        public virtual void Add(TEntity entity)
        {
            dbSetEntity.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if(databaseContext.Entry(entity).State==EntityState.Detached)
            {
                dbSetEntity.Attach(entity);
            }
            dbSetEntity.Remove(entity);
        }

        public virtual void DeleteByGuid(Guid guid)
        {
            TEntity entityToDelete = dbSetEntity.Find(guid);
            Delete(entityToDelete);
        }

        public virtual List<TEntity> GetAll()
        {
            return dbSetEntity.ToList();
        }

        public virtual TEntity GetByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entiry)
        {
            dbSetEntity.Attach(entiry);
            databaseContext.Entry(entiry).State = EntityState.Modified;
        }
    }
}
