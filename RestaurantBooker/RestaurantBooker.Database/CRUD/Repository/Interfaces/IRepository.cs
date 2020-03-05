using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CRUD.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetByGuid(Guid guid);
        void Add(TEntity entity);
        void Update(TEntity entiry);
        void Delete(TEntity entity);
        void DeleteByGuid(Guid guid);

    }
}
