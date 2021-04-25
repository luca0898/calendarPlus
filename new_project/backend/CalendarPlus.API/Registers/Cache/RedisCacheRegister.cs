using CalendarPlus.Cache.Redis;
using CalendarPlus.SystemObjects.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.API.Registers.Cache
{
    public static class RedisCacheRegister
    {
        public static void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(setup =>
            {
                setup.Configuration = configuration.GetConnectionString("CalendarPlusRedisCache");
            });

            services.AddSingleton<ICacheProvider, RedisCacheProvider>();
        }
    }
}
