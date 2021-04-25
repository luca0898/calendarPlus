using CalendarPlus.Db.SQL.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CalendarPlus.Db.SQL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext Context => this;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Claim>();
            modelBuilder.HasDefaultSchema("CalendarPlusDb");

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ScheduleMap());
        }
    }
}
