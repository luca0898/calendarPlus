using CalendarPlus.Db.SQL.Repositories.Shared;
using CalendarPlus.Product.Contracts.Repositories;
using CalendarPlus.Product.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalendarPlus.Db.SQL.Repositories
{
    public class ScheduleRepository : GenericRelationalRepository<Schedule>, IScheduleRepository
    {

        public ScheduleRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
