using CalendarPlus.Db.SQL.Repositories;
using CalendarPlus.Product.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers.Contracts.Repositories
{
    public class RegistryRepositories
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
