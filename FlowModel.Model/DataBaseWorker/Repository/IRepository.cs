using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FlowModel.Model
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetList();

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
        
        TEntity Get(object id);
        
        void Insert(TEntity entity);
        
        void Update(TEntity entity);
        
        void Delete(TEntity entity);
        
        void Delete(object id);
    }
}