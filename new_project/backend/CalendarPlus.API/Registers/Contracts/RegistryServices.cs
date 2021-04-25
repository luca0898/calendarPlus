using CalendarPlus.Product.Contracts.Services;
using CalendarPlus.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers.Contracts.Services
{
    public class RegistryServices
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<IScheduleService, ScheduleService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
