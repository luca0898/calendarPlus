using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarPlus.PRODUCT.Contracts.Services;
using CalendarPlus.Service;

namespace CalendarPlus.Registers.Contracts.Services
{
    public class RegistryServices
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<IScheduleService, ScheduleService>();
        }
    }
}
