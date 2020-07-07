using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AzSM.Authorization.Roles;
using AzSM.Authorization.Users;
using AzSM.MultiTenancy;
using AzSM.Events;

namespace AzSM.EntityFrameworkCore
{
    public class AzSMDbContext : AbpZeroDbContext<Tenant, Role, User, AzSMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<AzSM.Events.Event> Events { get; set; }

        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }

        public AzSMDbContext(DbContextOptions<AzSMDbContext> options)
            : base(options)
        {
        }
    }
}
