using System;
using System.Collections.Generic;

namespace FlowModel.Model
{
    public interface IRepository<TEntity> : IDisposable 
        where TEntity : class
    {
        IEnumerable<TEntity> GetList();
        
        TEntity Get(object id);
            
        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}