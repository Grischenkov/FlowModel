using System;
using System.Data.Entity;

namespace FlowModel.Model
{
    public abstract class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        private bool _disposed = false;

        protected TContext Context { get; set; }

        public UnitOfWork()
        {
            
        }
        
        public UnitOfWork(TContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }

            _disposed = true;
        }
    }
    
    public abstract class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;
        public UnitOfWork()
        {
            
        }

        public void Commit()
        {
            
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    
                }
            }

            _disposed = true;
        }
    }
}