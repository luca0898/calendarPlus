using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using CalendarPlus.Db.SQL.Mappers;
using CalendarPlus.PRODUCT.Entities;

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
