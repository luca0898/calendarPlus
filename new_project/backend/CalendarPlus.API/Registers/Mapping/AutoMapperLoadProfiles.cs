using AutoMapper;
using CalendarPlus.API.Registers.Mapping.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers.Mapping
{
    public class AutoMapperLoadProfiles
    {
        public static void Load(IServiceCollection services)
        {
            var x = new MapperConfiguration(config =>
            {
                config.AllowNullDestinationValues = true;
                config.AllowNullCollections = true;

                // Adding each profile
                config.AddProfile<ScheduleProfile>();
                config.AddProfile<UserProfile>();
                // ...
            }).CreateMapper();

            services.AddSingleton(register => x);
        }
    }
}
