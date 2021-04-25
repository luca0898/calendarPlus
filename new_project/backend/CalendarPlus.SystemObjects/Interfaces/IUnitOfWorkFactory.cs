using System.Data;

namespace CalendarPlus.SystemObjects.Interfaces
{
    public interface IUnitOfWorkFactory<TUnitOfWork> where TUnitOfWork : IUnitOfWork
    {
        IUnitOfWork Create();
        IUnitOfWork Create(IsolationLevel isolationLevel);
    }
}
