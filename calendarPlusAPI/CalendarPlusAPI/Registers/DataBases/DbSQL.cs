using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using CalendarPlus.Db.SQL;
using CalendarPlus.SystemObjects.Interfaces;
using CalendarPlus.SystemObjects;

namespace CalendarPlus.Registers.DataBases
{
    public class DbSQL
    {
        public static void Load(IServiceCollection services)
        {
            services
                .AddScoped<ApplicationDbContext>()
                .AddScoped<DbContext>((x) => x.GetService<ApplicationDbContext>())
                .AddScoped<IUnitOfWorkFactory<UnitOfWork>, UnitOfWorkFactory>();
        }
    }
}
