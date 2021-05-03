using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FlowModel.Model
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetList();

        TEntity Get(object id);
        
        void Insert(TEntity entity);
        
        void Update(TEntity entity);

        void Delete(object id);
        void Delete(TEntity entity);
    }
}