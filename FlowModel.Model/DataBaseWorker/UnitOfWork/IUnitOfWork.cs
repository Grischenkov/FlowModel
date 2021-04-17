using System;

namespace FlowModel.Model
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}