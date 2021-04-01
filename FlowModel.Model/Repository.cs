using System;
using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        private bool _disposed = false;
        
        private DataBaseContext _context;
        private DbSet<TEntity> _dbSet;
        
        public Repository(DataBaseContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>;
        }

        public virtual IEnumerable<TEntity> GetList()
        {
            return _dbSet.ToList();
        }

        public virtual TEntity Get(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        
        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entityToDelete);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}