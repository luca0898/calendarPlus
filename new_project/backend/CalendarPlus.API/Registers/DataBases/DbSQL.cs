using CalendarPlus.Db.SQL;
using CalendarPlus.SystemObjects;
using CalendarPlus.SystemObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalendarPlus.Registers.DataBases
{
    public class DbSQL
    {
        public static void Load(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<ApplicationDbContext>(options =>
                {
                    string connectionString = configuration.GetConnectionString("CalendarPlusDbSqlConnectionString");
                    options.UseSqlServer(connectionString, o => o.MigrationsAssembly("CalendarPlus.Repository.Db.SQL.Migrations"));
                });

            services
                .AddScoped<ApplicationDbContext>()
                .AddScoped<DbContext>((x) => x.GetService<ApplicationDbContext>())
                .AddScoped<IUnitOfWorkFactory<UnitOfWork>, UnitOfWorkFactory>();
        }
    }
}
