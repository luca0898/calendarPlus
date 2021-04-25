using CalendarPlus.API.Registers.Cache;
using CalendarPlus.Registers.Authentication;
using CalendarPlus.Registers.Contracts.Repositories;
using CalendarPlus.Registers.Contracts.Services;
using CalendarPlus.Registers.DataBases;
using CalendarPlus.Registers.Mapping;
using CalendarPlus.Registers.Swagger;
using CalendarPlus.Registers.Validators;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers
{
    public static class LoadRegistrations
    {
        public static void ConfigureContainers(IServiceCollection services, IConfiguration configuration)
        {
            LoadValidators.Load(services);
            DbSQL.Load(services, configuration);
            RedisCacheRegister.Load(services, configuration);
            AuthenticationRegister.Load(services, configuration);
            SwaggerRegister.Load(services, configuration);

            AutoMapperLoadProfiles.Load(services);
            RegistryServices.Load(services);
            RegistryRepositories.Load(services);
        }
    }
}
