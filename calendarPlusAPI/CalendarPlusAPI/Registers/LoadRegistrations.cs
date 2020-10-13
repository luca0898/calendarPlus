using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CalendarPlus.Registers.Contracts.Repositories;
using CalendarPlus.Registers.Contracts.Services;
using CalendarPlus.Registers.DataBases;
using CalendarPlus.Registers.Mapping;

namespace CalendarPlus.Registers
{
    public static class LoadRegistrations
    {
        public static void ConfigureContainers(IServiceCollection services)
        {
            AutoMapperLoadProfiles.Load(services);
            DbSQL.Load(services);
            RegistryServices.Load(services);
            RegistryRepositories.Load(services);
        }
    }
}
