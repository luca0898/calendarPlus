using CalendarPlus.SystemObjects;
using CalendarPlus.SystemObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CalendarPlus.Db.SQL
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory<UnitOfWork>
    {
        private readonly DbContext _dbContext;
        public UnitOfWorkFactory(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IUnitOfWork Create()
        {
            return new UnitOfWork(_dbContext);
        }

        public IUnitOfWork Create(IsolationLevel isolationLevel)
        {
            return new UnitOfWork(_dbContext, isolationLevel);
        }
    }
}
