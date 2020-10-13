using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarPlus.PRODUCT.Contracts.Repositories;
using CalendarPlus.REPOSITORIES;

namespace CalendarPlus.Registers.Contracts.Repositories
{
    public class RegistryRepositories
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<IScheduleRepository, ScheduleRepository>();
        }
    }
}
