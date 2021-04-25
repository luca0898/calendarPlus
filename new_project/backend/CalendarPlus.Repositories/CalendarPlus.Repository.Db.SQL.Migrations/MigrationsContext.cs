using CalendarPlus.Db.SQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace CalendarPlus.Repository.Db.SQL.Migrations
{
    public class MigrationsContext : ApplicationDbContext
    {
        public MigrationsContext() : base(new DbContextOptions<ApplicationDbContext>())
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();

            var currentDirectory = Directory.GetCurrentDirectory();

            builder.AddJsonFile(Path.Combine(currentDirectory, $"appsettings.json"), false, true);
            
            OverwriteWithCustomEnvironmentSettings(builder, currentDirectory);

            IConfigurationRoot config = builder
                .AddEnvironmentVariables()
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("CalendarPlusDbSqlConnectionString"));

            base.OnConfiguring(optionsBuilder);
        }

        private static void OverwriteWithCustomEnvironmentSettings(ConfigurationBuilder builder, string currentDirectory)
        {
            string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (string.IsNullOrEmpty(environmentName) == false)
            {
                string customConfigPath = Path.Combine(currentDirectory, $"appsettings.{environmentName}.json");

                if (File.Exists(customConfigPath))
                {
                    Console.WriteLine($"\nEnvironment Name:{environmentName}\n");

                    builder.AddJsonFile(customConfigPath, true, true);
                }
                else
                {
                    Console.WriteLine($"\nEnvironment 'appsettings.{environmentName}.json' configuration file not found\n");
                }
            }
        }
    }
}
