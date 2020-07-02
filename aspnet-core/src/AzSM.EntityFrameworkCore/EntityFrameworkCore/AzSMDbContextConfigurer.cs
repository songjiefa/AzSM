using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AzSM.EntityFrameworkCore
{
    public static class AzSMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AzSMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AzSMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
