using CalendarPlus.Db.SQL.Repositories.Shared;
using CalendarPlus.Product.Contracts.Repositories;
using CalendarPlus.Product.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalendarPlus.Db.SQL.Repositories
{
    public class UserRepository : GenericRelationalRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
