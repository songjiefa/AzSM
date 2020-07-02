using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AzSM.Authorization.Roles;
using AzSM.Authorization.Users;
using AzSM.MultiTenancy;

namespace AzSM.EntityFrameworkCore
{
    public class AzSMDbContext : AbpZeroDbContext<Tenant, Role, User, AzSMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AzSMDbContext(DbContextOptions<AzSMDbContext> options)
            : base(options)
        {
        }
    }
}
