using CalendarPlus.Product.Contracts.Repositories;
using CalendarPlus.Product.Contracts.Services;
using CalendarPlus.Product.Entities;
using CalendarPlus.Services.Shared;
using CalendarPlus.SystemObjects;
using CalendarPlus.SystemObjects.Interfaces;

namespace CalendarPlus.Service
{
    public class ScheduleService : GenericCachedEntityService<Schedule>, IScheduleService
    {
        public ScheduleService(
            ICurrentSessionUser currentSessionUser,
            ICacheProvider cacheProvider,
            IScheduleRepository scheduleRepository,
            IUnitOfWorkFactory<UnitOfWork> uow) : base(currentSessionUser, cacheProvider, scheduleRepository, uow)
        {
        }
    }
}
