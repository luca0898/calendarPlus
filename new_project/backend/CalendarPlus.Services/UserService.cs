using CalendarPlus.Product.Contracts.Repositories;
using CalendarPlus.Product.Contracts.Services;
using CalendarPlus.Product.Entities;
using CalendarPlus.Services.Shared;
using CalendarPlus.SystemObjects;
using CalendarPlus.SystemObjects.Interfaces;

namespace CalendarPlus.Service
{
    public class UserService : GenericCachedEntityService<User>, IUserService
    {
        public UserService(
            ICurrentSessionUser currentSessionUser,
            ICacheProvider cacheProvider,
            IUserRepository repository,
            IUnitOfWorkFactory<UnitOfWork> uow) : base(currentSessionUser, cacheProvider, repository, uow)
        {
        }
    }
}
